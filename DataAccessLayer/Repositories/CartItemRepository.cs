using DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CartItemRepository : MainRepository<Models.CartItem>, IRepositories.ICartItemRepository
    {
        public CartItemRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
