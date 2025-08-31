using CoreLayer.Enums;

namespace PresentationLayer.ViewModels
{
    public class CustomerHomeFilter
    {
        public TournamentTitles? Title { get; set; } = TournamentTitles.EgyptianPremierLeague;
        public string? Season { get; set; } = "2025/2026";
    }
}
