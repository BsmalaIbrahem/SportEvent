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
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;
        public TicketStatus Status { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string? PaymentMethod { get; set; }
        public string? PaymentId { get; set; }
        public string? SessionId { get; set; }
        public string? ReferenceId { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; } = 0;
        public ICollection<TicketMatch> TicketMatches { get; set; } = new List<TicketMatch>();
        [NotMapped]
        public decimal SubTotal  =>  TicketMatches.Sum(tm => tm.Price * tm.Quantity);

    }
}
