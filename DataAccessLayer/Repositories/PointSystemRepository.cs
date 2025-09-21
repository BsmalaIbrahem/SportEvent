using DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class PointSystemRepository : MainRepository<Models.PointSystem>, IRepositories.IPointSystemRepository
    {
        public PointSystemRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
