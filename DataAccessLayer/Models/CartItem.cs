using CoreLayer.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    [PrimaryKey(nameof(CartId), nameof(TicketCategory))]
    public class CartItem : BaseModel
    {
        public int CartId { get; set; }
        public Cart Cart { get; set; } = null!;
        public TicketCategory TicketCategory { get; set; }
        public int Quantity { get; set; } = 1;
    }
}
