using DataAccessLayer.Models;

namespace PresentationLayer.ViewModels
{
    public class TeamsWithTicketsVM
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; } = string.Empty;
        public string? TeamLogoUrl { get; set; }
        public int TicketsSold { get; set; }
    }
}
