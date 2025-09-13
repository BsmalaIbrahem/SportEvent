using CoreLayer.Enums;
using CoreLayer.Utility;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories.IRepositories;
using DinkToPdf;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stripe;
using Stripe.Checkout;
using System.Threading.Tasks;
using DinkToPdf.Contracts;
using System.Globalization;

namespace PresentationLayer.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CheckoutController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;
        private readonly ICustomEmailSender _customEmailSender;
        private readonly ILogger<CheckoutController> _logger;
        public CheckoutController(IUnitOfWork unitOfWork, IConfiguration configuration, ICustomEmailSender _customEmailSender, ILogger<CheckoutController> _logger)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
            this._logger = _logger;
            this._customEmailSender = _customEmailSender;
        }

        public async Task<IActionResult> Success(string referenceId)
        {
            var ticket = await _unitOfWork.TicketRepository.GetOneAsync(x => x.ReferenceId == referenceId, includeChain:x=>x.Include(q => q.TicketMatches));

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

            if(session.Status == "complete")
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
                            includeChain: q => q.Include(t => t.TicketMatches).ThenInclude(tm => tm.Match)
                                                        .ThenInclude(m => m.HomeTeam)
                                                        .Include(t => t.TicketMatches)
                                                        .ThenInclude(tm => tm.Match)
                                                        .ThenInclude(m => m.AwayTeam)
                                               .Include(t => t.User));

                        if (ticket != null && ticket.Status == TicketStatus.Pending)
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
                               foreach(var cart in carts)
                               {
                                    await _unitOfWork.CartItemRepository.DeleteAsync(ci => ci.CartId == cart.Id);
                                    await _unitOfWork.CartRepository.DeleteAsync(c => c.Id == cart.Id);

                               }
                                await _unitOfWork.CartItemRepository.SaveChangesAsync();
                                await _unitOfWork.CartRepository.SaveChangesAsync();

                                try
                                {
                                    var pdfBytesList = new List<byte[]>();
                                    var attachmentNames = new List<string>();

                                    foreach (var ticketMatch in ticket.TicketMatches)
                                    {
                                        var pdfBytes = GenerateTicketPdf(ticket, ticketMatch);
                                        pdfBytesList.Add(pdfBytes);
                                        attachmentNames.Add($"ticket_{ticketMatch.Id}.pdf");
                                    }

                                    var email = ticket?.User?.Email ?? "test@g.com";
                                    await _customEmailSender.SendEmailAsync(email, "Ticket Confirmed", "Your tickets are attached.", pdfBytesList, attachmentNames);
                                }
                                catch (Exception ex)
                                {
                                    _logger.LogError(ex, $"Failed to generate/send PDFs for ticket {ticket.Id}.");
                                }
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


    

    private byte[] GenerateTicketPdf(Ticket ticket, TicketMatch ticketMatch)
        {
            // تعريف المتغيرات أولًا
            var ticketGuid = ticket.ReferenceId; // UUID format
            var currentDate = DateTime.Now.ToString("MMM dd, yyyy hh:mm tt");
            var matchName = ticketMatch.Match?.HomeTeam.Name + " VS " + ticketMatch.Match?.AwayTeam.Name ?? "Unknown Match";
            var matchDateTime = ticketMatch.Match?.MatchDate.ToString("MMM dd, yyyy hh:mm tt") ?? "N/A";
            var stadiumName = ticketMatch.Match?.Location ?? "Unknown Stadium";
            var teamName = ticketMatch.Match?.HomeTeam?.Name ?? "Unknown Team";
            var ticketCategory = ticketMatch.Category.ToString() ?? "General";
            var ticketQuantity = ticketMatch.Quantity.ToString() ?? "1";
            var ticketPrice = (ticketMatch.Price * ticketMatch.Quantity).ToString("C", new CultureInfo("EG")) ?? "EGP 0.00";
            var ticketId = ticket.Id.ToString();

            var htmlContent = $@"
    <!DOCTYPE html>
    <html lang='en'>
    <head>
        <meta charset='UTF-8'>
        <meta name='viewport' content='width=device-width, initial-scale=1.0'>
        <title>Matchy Ticket</title>
        <link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css'>
        <style>
            @import url('https://fonts.googleapis.com/css2?family=Poppins:wght@300;400;500;600;700&display=swap');
        
            * {{ margin: 0; padding: 0; box-sizing: border-box; font-family: 'Poppins', sans-serif; }}
            body {{ background: linear-gradient(135deg, #6a11cb 0%, #2575fc 100%); display: flex; justify-content: center; align-items: center; min-height: 100vh; padding: 20px; }}
            .ticket-container {{ width: 100%; max-width: 800px; display: flex; flex-direction: column; gap: 20px; }}
            .ticket {{ background: white; border-radius: 15px; overflow: hidden; box-shadow: 0 10px 30px rgba(0, 0, 0, 0.2); color: #333; position: relative; }}
            .ticket-header {{ padding: 20px; text-align: center; background: #1a2a6c; color: white; border-bottom: 2px dashed rgba(255, 255, 255, 0.3); }}
            .ticket-header h1 {{ font-size: 28px; margin-bottom: 5px; text-shadow: 1px 1px 3px rgba(0, 0, 0, 0.3); }}
            .ticket-header p {{ font-size: 16px; opacity: 0.9; }}
            .ticket-body {{ padding: 25px; display: flex; flex-wrap: wrap; }}
            .left-section {{ flex: 2; padding-right: 20px; }}
            .right-section {{ flex: 1; border-left: 2px dashed #ddd; padding-left: 20px; display: flex; flex-direction: column; justify-content: center; align-items: center; }}
            .info-row {{ display: flex; justify-content: space-between; margin-bottom: 12px; padding-bottom: 12px; border-bottom: 1px dashed #eee; }}
            .info-label {{ font-weight: 600; font-size: 16px; color: #555; }}
            .info-value {{ font-size: 16px; text-align: right; }}
            .order-number {{ background: #f8f9fa; padding: 12px; border-radius: 8px; text-align: center; margin: 20px 0; font-family: monospace; font-size: 14px; letter-spacing: 1px; color: #1a2a6c; }}
            .match-details {{ background: #f8f9fa; padding: 15px; border-radius: 10px; margin-top: 20px; }}
            .match-details h3 {{ color: #1a2a6c; margin-bottom: 15px; text-align: center; }}
            .match-info {{ display: flex; justify-content: space-between; margin-bottom: 10px; }}
            .barcode {{ text-align: center; margin: 20px 0; }}
            .barcode-placeholder {{ width: 150px; height: 80px; background: linear-gradient(90deg, #eee 0%, #fff 10%, #eee 20%); background-size: 200% 100%; animation: loading 1.5s infinite; border-radius: 5px; }}
            @keyframes loading {{ 0% {{ background-position: 100% 50%; }} 100% {{ background-position: 0 50%; }} }}
            .ticket-id {{ font-family: monospace; font-size: 14px; color: #555; margin-top: 10px; }}
            .footer {{ text-align: center; padding: 15px; background: #f8f9fa; border-top: 2px dashed #ddd; font-size: 14px; color: #666; }}
            .watermark {{ position: absolute; top: 50%; left: 50%; transform: translate(-50%, -50%) rotate(-45deg); font-size: 70px; opacity: 0.05; font-weight: bold; pointer-events: none; white-space: nowrap; color: #1a2a6c; }}
            .ticket-category {{ display: inline-block; padding: 5px 15px; background: #1a2a6c; color: white; border-radius: 20px; font-size: 14px; margin-top: 10px; }}
            .price {{ font-size: 24px; font-weight: bold; color: #1a2a6c; margin: 10px 0; }}
            .terms {{ font-size: 12px; color: #777; text-align: center; max-width: 200px; margin-top: 10px; }}
            @media (max-width: 768px) {{ .ticket-body {{ flex-direction: column; }} .right-section {{ border-left: none; border-top: 2px dashed #ddd; padding-left: 0; padding-top: 20px; margin-top: 20px; }} }}
            @media print {{ body {{ background: none; padding: 0; }} .ticket {{ box-shadow: none; max-width: none; }} }}
        </style>
    </head>
    <body>
        <div class='ticket-container'>
            <div class='ticket'>
                <div class='watermark'>MATCHY</div>
            
                <div class='ticket-header'>
                    <h1>Matchy Ticket #{ticketId}</h1>
                    <p>Thank you for your purchase! Your payment has been processed successfully.</p>
                </div>
            
                <div class='ticket-body'>
                    <div class='left-section'>
                        <div class='info-row'>
                            <span class='info-label'>Order Number:</span>
                            <span class='info-value'>#{ticketGuid}</span>
                        </div>
                    
                        <div class='info-row'>
                            <span class='info-label'>Date:</span>
                            <span class='info-value'>{currentDate}</span>
                        </div>
                    
                        <div class='info-row'>
                            <span class='info-label'>Payment Method:</span>
                            <span class='info-value'>Credit Card</span>
                        </div>
                    
                        <div class='info-row'>
                            <span class='info-label'>Status:</span>
                            <span class='info-value'>Confirmed</span>
                        </div>
                    
                        <div class='match-details'>
                            <h3>Match Information</h3>
                            <div class='match-info'>
                                <span class='info-label'>Match:</span>
                                <span class='info-value'>{matchName}</span>
                            </div>
                            <div class='match-info'>
                                <span class='info-label'>Date & Time:</span>
                                <span class='info-value'>{matchDateTime}</span>
                            </div>
                            <div class='match-info'>
                                <span class='info-label'>Stadium:</span>
                                <span class='info-value'>{stadiumName}</span>
                            </div>
                            <div class='match-info'>
                                <span class='info-label'>Team:</span>
                                <span class='info-value'>{teamName}</span>
                            </div>
                            <div class='match-info'>
                                <span class='info-label'>Category:</span>
                                <span class='info-value'>{ticketCategory}</span>
                            </div>
                            <div class='match-info'>
                                <span class='info-label'>Quantity:</span>
                                <span class='info-value'>{ticketQuantity}</span>
                            </div>
                        </div>
                    </div>
                
                    <div class='right-section'>
                        <div class='price'>{ticketPrice}</div>
                        <div class='ticket-category'>{ticketCategory}</div>
                    
                        <div class='barcode'>
                            <div class='barcode-placeholder'></div>
                            <div class='ticket-id'>Ticket ID: {ticketId}</div>
                        </div>
                    
                        <div class='terms'>
                            This ticket is non-transferable and non-refundable. Please arrive 60 minutes before the match.
                        </div>
                    </div>
                </div>
            
                <div class='footer'>
                    <p>This ticket grants access to the specified match only | &copy; 2025 Matchy. All rights reserved.</p>
                </div>
            </div>
        </div>
    </body>
    </html>";

            // استبدال البيانات الديناميكية
            htmlContent = htmlContent
                .Replace("{ticketGuid}", ticketGuid)
                .Replace("{currentDate}", currentDate)
                .Replace("{matchName}", matchName)
                .Replace("{matchDateTime}", matchDateTime)
                .Replace("{stadiumName}", stadiumName)
                .Replace("{teamName}", teamName)
                .Replace("{ticketCategory}", ticketCategory)
                .Replace("{ticketQuantity}", ticketQuantity)
                .Replace("{ticketPrice}", ticketPrice)
                .Replace("{ticketId}", ticketId);

            // تهيئة DinkToPdf
            var converter = new SynchronizedConverter(new PdfTools());
            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10, Bottom = 10, Left = 10, Right = 10 }
            },
                Objects = {
                new ObjectSettings {
                    HtmlContent = htmlContent,
                    WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = "" },
                    PagesCount = true
                }
            }
            };

            byte[] pdfBytes;
            try
            {
                pdfBytes = converter.Convert(doc);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Conversion failed for ticket {ticket.Id}. Returning empty PDF.");
                pdfBytes = new byte[0]; 
            }

            return pdfBytes;
        }
    }
}
