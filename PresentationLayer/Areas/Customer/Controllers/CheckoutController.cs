using CoreLayer.Enums;
using CoreLayer.Utility;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories.IRepositories;
using DinkToPdf;
using DinkToPdf.Contracts;
using Hangfire;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.Services.IServices;
using Stripe;
using Stripe.Checkout;
using System.Globalization;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CheckoutController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;
        private readonly ICustomEmailSender _customEmailSender;
        private readonly ILogger<CheckoutController> _logger;
        private readonly IConverter _converter;
        public CheckoutController(IUnitOfWork unitOfWork, IConfiguration configuration, ICustomEmailSender _customEmailSender, ILogger<CheckoutController> _logger, IConverter converter)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
            this._logger = _logger;
            this._customEmailSender = _customEmailSender;
            _converter = converter;
        }

        public async Task<IActionResult> Success(string referenceId)
        {
            var ticket = await _unitOfWork.TicketRepository.GetOneAsync(x => x.ReferenceId == referenceId, includeChain: x => x.Include(q => q.TicketMatches));

            if (ticket == null)
            {
                return NotFound();
            }

            if (ticket.Status != TicketStatus.Confirmed)
            {
                TempData["Error"] = "The ticket is either expired.";
                return View();
            }

            var sessionService = new SessionService();
            var session = await sessionService.GetAsync(ticket.SessionId);

            if (session.Status == "complete")
            {
                using var transaction = await _unitOfWork.BeginTransactionAsync();
                try
                {
                    ticket.Status = TicketStatus.Confirmed;
                    _unitOfWork.TicketRepository.Update(ticket);
                    await _unitOfWork.TicketRepository.SaveChangesAsync();

                    var carts = await _unitOfWork.CartRepository.GetAllAsync(c => c.UserId == ticket.UserId);
                    foreach (var cart in carts)
                    {
                        await _unitOfWork.CartItemRepository.DeleteAsync(ci => ci.CartId == cart.Id);
                        await _unitOfWork.CartRepository.DeleteAsync(c => c.Id == cart.Id);

                    }
                    await _unitOfWork.CartItemRepository.SaveChangesAsync();
                    await _unitOfWork.CartRepository.SaveChangesAsync();

                    await transaction.CommitAsync();
                    TempData["Success"] = "Your payment was successful! Your tickets have been booked.";
                    return View(ticket);
                }
                catch
                {
                    await transaction.RollbackAsync();
                    TempData["Error"] = "An error occurred while confirming your booking.";
                    return RedirectToAction("Index", "Cart", new { Area = "Customer" });
                }
            }

            TempData["Error"] = "The ticket is either expired or not available. Please try again.";
            return View("Expired");
        }

        public async Task<IActionResult> Cancel(string referenceId)
        {
            var ticket = await _unitOfWork.TicketRepository.GetOneAsync(x => x.ReferenceId == referenceId);

            if (ticket == null)
            {
                return NotFound();
            }

            if (ticket.Status == TicketStatus.Confirmed)
            {
                return RedirectToAction(nameof(Success), new { referenceId });
            }

            ticket.Status = TicketStatus.Cancelled;
            _unitOfWork.TicketRepository.Update(ticket);
            await _unitOfWork.TicketRepository.SaveChangesAsync();

            TempData["Error"] = "Your payment was cancelled. Please try again.";

            return View();
        }


        [HttpPost]
        [Route("/Customer/Checkout/StripeWebhook")]
        public async Task<IActionResult> StripeWebhook()
        {
            var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();
            try
            {
                _logger.LogInformation("Received Stripe webhook event.");
                var stripeEvent = EventUtility.ConstructEvent(
                    json,
                    Request.Headers["Stripe-Signature"],
                    _configuration["Stripe:WebhookSecret"]);

                _logger.LogInformation($"Processing event type: {stripeEvent.Type}");

                if (stripeEvent.Type == EventTypes.PaymentIntentSucceeded)
                {
                    _logger.LogInformation($"Processing payment_intent.succeeded for payment intent {stripeEvent.Data.Object}.");
                    var paymentIntent = stripeEvent.Data.Object as PaymentIntent;
                    Session session = null;

                    if (paymentIntent != null)
                    {
                        var sessionService = new SessionService();
                        var sessions = await sessionService.ListAsync(new SessionListOptions
                        {
                            PaymentIntent = paymentIntent.Id
                        });
                        session = sessions.FirstOrDefault();
                    }

                    if (session != null)
                    {
                        var ticket = await _unitOfWork.TicketRepository.GetOneAsync(
                            t => t.SessionId == session.Id,
                            includeChain: q => q.Include(t => t.TicketMatches)
                                                .ThenInclude(tm => tm.Match)
                                                .ThenInclude(m => m.HomeTeam)
                                                .Include(t => t.TicketMatches)
                                                .ThenInclude(tm => tm.Match)
                                                .ThenInclude(m => m.AwayTeam)
                                                .Include(t => t.User));

                        if (ticket != null)
                        {
                            using var transaction = await _unitOfWork.BeginTransactionAsync();
                            try
                            {
                                ticket.Status = TicketStatus.Confirmed;
                                _unitOfWork.TicketRepository.Update(ticket);
                                await _unitOfWork.TicketRepository.SaveChangesAsync();
                                await transaction.CommitAsync();
                                _logger.LogInformation($"Ticket {ticket.Id} set to Confirmed.");

                                var carts = await _unitOfWork.CartRepository.GetAllAsync(c => c.UserId == ticket.UserId);
                                foreach (var cart in carts)
                                {
                                    await _unitOfWork.CartItemRepository.DeleteAsync(ci => ci.CartId == cart.Id);
                                    await _unitOfWork.CartRepository.DeleteAsync(c => c.Id == cart.Id);
                                }
                                await _unitOfWork.CartItemRepository.SaveChangesAsync();
                                await _unitOfWork.CartRepository.SaveChangesAsync();

                                BackgroundJob.Enqueue<IPdfService>(x => x.GenerateAndSendPdfsInBackground(ticket.Id, JobCancellationToken.Null));

                                _logger.LogInformation("PDF generation and email sending enqueued for ticket {ticket_id}", ticket.Id);
                            }
                            catch (Exception ex)
                            {
                                await transaction.RollbackAsync();
                                _logger.LogError(ex, $"Error confirming ticket for session {session.Id}.");
                                throw;
                            }
                        }
                        else
                        {
                            _logger.LogWarning($"Ticket not found or not Pending for session {session.Id}.");
                        }
                    }
                    else
                    {
                        _logger.LogWarning("No valid session found for PaymentIntent.");
                    }
                }
                else
                {
                    _logger.LogInformation($"Ignored webhook event: {stripeEvent.Type}");
                }

                return Ok();
            }
            catch (StripeException ex)
            {
                _logger.LogError(ex, "Stripe webhook error: {Message}", ex.Message);
                return BadRequest();
            }
        }

    }
 }
