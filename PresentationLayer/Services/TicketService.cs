using DataAccessLayer.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace PresentationLayer.Services
{
    public class TicketService
    {
        private readonly IUnitOfWork _unitOfWork;
        public TicketService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> GetTotalTicketsForMatch(int matchId, string userId)
        {
            var totalTickets = await _unitOfWork.TicketMatchRepository.CountAsync(t => t.MatchId == matchId && t.Ticket.UserId == userId, includeChain: x=>x.Include(q=>q.Ticket));
            return totalTickets;
        }
    }
}
