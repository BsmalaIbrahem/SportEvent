using CoreLayer.Enums;
using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.ViewModels
{
    public class MatchTicketsVM
    {
        [Required]
        public TicketCategory Category { get; set; } = TicketCategory.CAT2;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int HomeTickets { get; set; } = 0;
        [Required]
        public int AwayTickets { get; set; } = 0;
    }
}
