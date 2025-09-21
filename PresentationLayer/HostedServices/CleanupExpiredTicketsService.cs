using CoreLayer.Enums;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using Stripe.Checkout;

namespace PresentationLayer.HostedServices
{
    public class CleanupExpiredTicketsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly SessionService _sessionService;

        public CleanupExpiredTicketsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _sessionService = new SessionService();
        }

        public async Task Execute()
        {
            var expiredTickets = await _unitOfWork.TicketRepository.GetAllAsync(
                t => t.Status == TicketStatus.Pending && t.ExpiryDate < DateTime.Now.AddMinutes(-2),
                includeChain: q => q.Include(t => t.TicketMatches).ThenInclude(tm => tm.Match));

            foreach (var ticket in expiredTickets)
            {
                using var transaction = await _unitOfWork.BeginTransactionAsync();
                try
                {
                    if (!string.IsNullOrEmpty(ticket.SessionId))
                    {
                        var session = await _sessionService.GetAsync(ticket.SessionId);
                        if (session.Status == "complete")
                        {
                            ticket.Status = TicketStatus.Confirmed;
                            _unitOfWork.TicketRepository.Update(ticket);
                            await _unitOfWork.TicketRepository.SaveChangesAsync();
                            await transaction.CommitAsync();
                            continue;
                        }
                        else if (session.Status == "open")
                        {
                            await _sessionService.ExpireAsync(ticket.SessionId);
                        }
                    }

                    ticket.Status = TicketStatus.Expired;
                    foreach (var tm in ticket.TicketMatches)
                    {
                        var ticketPrice = await _unitOfWork.TicketPriceRepository.GetOneAsync(
                            tp => tp.MatchId == tm.MatchId && tp.Category == tm.Category);
                        if (ticketPrice != null)
                        {
                            if (tm.TeamId == tm.Match.HomeTeamId)
                                ticketPrice.HomeTickets += tm.Quantity;
                            else if (tm.TeamId == tm.Match.AwayTeamId)
                                ticketPrice.AwayTickets += tm.Quantity;
                            _unitOfWork.TicketPriceRepository.Update(ticketPrice);
                        }
                    }

                    _unitOfWork.TicketRepository.Update(ticket);
                    await _unitOfWork.TicketRepository.SaveChangesAsync();
                    await transaction.CommitAsync();
                }
                catch
                {
                    await transaction.RollbackAsync();
                }
            }
        }

    }
}
