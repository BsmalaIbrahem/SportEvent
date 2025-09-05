using DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class TicketPriceRepository : MainRepository<Models.TicketPrice>, IRepositories.ITicketPriceRepository
    {
        public TicketPriceRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
