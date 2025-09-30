namespace PresentationLayer.ViewModels
{
    public class DashboardVM
    {
        public int TotalMatches { get; set; }
        public int TotalUpcomingMatches { get; set; }
        public int TotalFinishedMatches { get; set; }
        public int TotalTeams { get; set; }
        public List<LeagueStandingVM> LeagueStandings { get; set; } = new List<LeagueStandingVM>();
        public int DrawsCount { get; set; }
        public int WinsCount { get; set; }
        public int TotalTicketsSold { get; set; }
        public decimal TotalRevenue { get; set; }
        public int TotalUsers { get; set; }
        public int ActiveUsers { get; set; }
        public List<TeamsWithTicketsVM> TeamsWithTickets { get; set; } = new List<TeamsWithTicketsVM>();
        public List<TicketsWithTypesVM> TicketsWithTypes { get; set; } = new List<TicketsWithTypesVM>();
    }
}
