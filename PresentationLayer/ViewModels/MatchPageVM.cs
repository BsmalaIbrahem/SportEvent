using DataAccessLayer.Models;

namespace PresentationLayer.ViewModels
{
    public class MatchPageVM
    {
        public Match CurrentMatch { get; set; }
        public List<TeamPlayer> TeamPlayer { get; set; }
        public List<MatchStatistic> Goals { get; set; } = new();
        public Match NextMatch { get; set; }
        public List<Match> UpcomingMatches { get; set; }
    }
}
