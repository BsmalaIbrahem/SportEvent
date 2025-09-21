using CoreLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class TicketMatch : BaseModel
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; } = null!;
        public int MatchId { get; set; }
        public Match Match { get; set; } = null!;
        public int TeamId { get; set; }
        public Team Team { get; set; } = null!;
        public decimal Price { get; set; }
        public TicketCategory Category { get; set; }
        public int Quantity { get; set; }
    }
}
