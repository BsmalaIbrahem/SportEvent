namespace PresentationLayer.ViewModels
{
    public class TicketPriceVM
    {
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int AvailableTickets { get; set; }
    }
}
