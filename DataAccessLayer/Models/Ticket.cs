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
    public class Ticket : BaseModel
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        [ForeignKey(nameof(MatchId))]
        public Match Match { get; set; } = null!;
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;
        public TicketStatus Status { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal Price { get; set; }
        public TicketCategory Category { get; set; }
        public string? PaymentMethod { get; set; }
        public string? PaymentId { get; set; }
        public string? SessionId { get; set; }
        public string? ReferenceId { get; set; }

    }
}
