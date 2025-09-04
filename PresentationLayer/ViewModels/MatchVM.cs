using CoreLayer.Enums;

namespace PresentationLayer.ViewModels
{
    public class MatchVM
    {
        public int Id { get; set; }
        public string HomeTeamName { get; set; } = string.Empty;
        public string AwayTeamName { get; set; } = string.Empty;
        public TournamentTitles TournamentName { get; set; }
        public DateTime MatchDate { get; set; }
        public string Status { get; set; } = string.Empty;
        public string? Location { get; set; }
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }
        public bool IsAvailableForBooking { get; set; } = false;
        public int AvailableTickets { get; set; }
        public List<TicketPriceVM> TicketPrices { get; set; } = new List<TicketPriceVM>();
    }
}
