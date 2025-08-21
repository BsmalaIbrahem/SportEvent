namespace PresentationLayer.ViewModels
{
    public class DashboardVM
    {
        public int TotalMatches { get; set; }
        public int TotalUpcomingMatches { get; set; }
        public int TotalFinishedMatches { get; set; }
        public int TotalTeams { get; set; }
        public List<LeagueStandingVM> LeagueStandings { get; set; } = new List<LeagueStandingVM>();
    }
}
