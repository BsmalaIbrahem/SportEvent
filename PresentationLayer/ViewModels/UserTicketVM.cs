using CoreLayer.Enums;

namespace PresentationLayer.ViewModels
{
    public class UserTicketVM
    {
        public int TicketId { get; set; }
        public string HomeTeam { get; set; } = string.Empty;
        public string AwayTeam { get; set; } = string.Empty;
        public DateTime MatchDate { get; set; }
        public TicketCategory Category { get; set; }
        public TicketStatus Status { get; set; }
        public decimal Price { get; set; }
    }
}
