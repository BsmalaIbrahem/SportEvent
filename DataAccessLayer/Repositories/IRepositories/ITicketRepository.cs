using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.IRepositories
{
    public interface ITicketRepository : IRepository<DataAccessLayer.Models.Ticket>
    {
        Task<IEnumerable<Ticket>> GetTicketsByMatchIdAsync(int matchId);
    }
}
