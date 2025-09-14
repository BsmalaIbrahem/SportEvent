using DataAccessLayer.Models;

namespace PresentationLayer.ViewModels
{
    public class CustomerHomeVM
    {
        public List<LeagueStandingVM> LeagueStandings { get; set; } = new List<LeagueStandingVM>();
        public Match? NextMatch { get; set; }
        public IEnumerable<New>? Blogs { get; set; }
        public IEnumerable<Match>? UpcommingMatches { get; set; }
    }
}
