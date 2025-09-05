using DataAccessLayer.Data;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CartRepository : MainRepository<Cart>, IRepositories.ICartRepository
    {
        public CartRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
