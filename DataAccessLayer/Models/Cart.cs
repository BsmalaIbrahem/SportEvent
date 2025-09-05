using CoreLayer.Enums;
using DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    
    public class Cart : BaseModel
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser? User { get; set; }
        public string? SessionId { get; set; }
        public int MatchId { get; set; }
        [ForeignKey(nameof(MatchId))]
        public Match Match { get; set; } = null!;
        public TicketCategory TicketCategory { get; set; }
        public int Quantity { get; set; } = 1;

    }
}
