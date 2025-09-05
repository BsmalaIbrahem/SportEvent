using CoreLayer.Enums;

namespace PresentationLayer.ViewModels
{
    public class EditCartItemVM
    {
        public int CartId { get; set; }
        public TicketCategory TicketCategory { get; set; }
        public int Quantity { get; set; }
    }
}
