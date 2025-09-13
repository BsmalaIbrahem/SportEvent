using DataAccessLayer.Data;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class TicketMatchRepository : MainRepository<TicketMatch>, ITicketMatchRepository
    {
        public TicketMatchRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
