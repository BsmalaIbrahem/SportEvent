using DataAccessLayer.Data;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class TicketRepository : MainRepository<Models.Ticket>, IRepositories.ITicketRepository
    {
        private readonly ApplicationDbContext _context;
        public TicketRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Ticket>> GetTicketsByMatchIdAsync(int matchId)
        {
            return await _context.Tickets
                                 .Where(t => t.MatchId == matchId)
                                 .ToListAsync();
        }
    }
}
