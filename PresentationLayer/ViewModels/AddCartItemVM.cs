using CoreLayer.Enums;
using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.ViewModels
{
    public class AddCartItemVM
    {
        [Required]
        public TicketCategory TicketCategory { get; set; }
        [Required]
        public int Quantity { get; set; } = 1;
    }
}
