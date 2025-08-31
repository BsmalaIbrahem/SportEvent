using CoreLayer.Enums;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.ViewModels;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index(CustomerHomeFilter filter)
        {
            var Tournment = await _unitOfWork.TournamentRepository.GetOneAsync(t => t.Title == filter.Title && t.Season == filter.Season);
            if (Tournment == null)
            {
                ModelState.AddModelError("", "No tournament found with the specified title and season.");
                return View();
            }

            var matches = await _unitOfWork.MatchRepository.GetAllAsync(m => m.TournamentId == Tournment.Id);
            var teams = new List<int>();
            foreach (var match in matches)
            {
                if (!teams.Contains(match.HomeTeamId))
                {
                    teams.Add(match.HomeTeamId);
                }
                if (!teams.Contains(match.AwayTeamId))
                {
                    teams.Add(match.AwayTeamId);
                }
            }
            var leagueStandings = new List<LeagueStandingVM>();

            foreach (var teamId in teams)
            {
                var matchesPlayed = await _unitOfWork.MatchRepository.CountAsync(x => x.TournamentId == Tournment.Id && x.Status != MatchStatus.Scheduled && (x.HomeTeamId == teamId || x.AwayTeamId == teamId));
                var wins = await _unitOfWork.MatchRepository.CountAsync(x => x.TournamentId == Tournment.Id && x.Status != MatchStatus.Scheduled && ((x.HomeTeamId == teamId && x.HomeScore > x.AwayScore) || (x.AwayTeamId == teamId && x.HomeScore < x.AwayScore)));
                var losses = await _unitOfWork.MatchRepository.CountAsync(x => x.TournamentId == Tournment.Id && x.Status != MatchStatus.Scheduled && ((x.HomeTeamId == teamId && x.HomeScore < x.AwayScore) || (x.AwayTeamId == teamId && x.HomeScore > x.AwayScore)));
                var draws = await _unitOfWork.MatchRepository.CountAsync(x => x.TournamentId == Tournment.Id && x.Status != MatchStatus.Scheduled && ((x.HomeTeamId == teamId && x.HomeScore == x.AwayScore) || (x.AwayTeamId == teamId && x.HomeScore == x.AwayScore)));

                int GoalsFor = 0, GoalsAgainst = 0;
                var homeMatches = await _unitOfWork.MatchRepository.GetAllAsync(x => x.TournamentId == Tournment.Id && x.Status != MatchStatus.Scheduled && x.HomeTeamId == teamId);
                GoalsFor += homeMatches.Sum(x => x.HomeScore);
                GoalsAgainst += homeMatches.Sum(x => x.AwayScore);
                var awayMatches = await _unitOfWork.MatchRepository.GetAllAsync(x => x.TournamentId == Tournment.Id && x.Status != MatchStatus.Scheduled && x.AwayTeamId == teamId);
                GoalsFor += awayMatches.Sum(x => x.AwayScore);
                GoalsAgainst += awayMatches.Sum(x => x.HomeScore);

                var goalDifference = GoalsFor - GoalsAgainst;

                var team = await _unitOfWork.TeamRepository.GetOneAsync(t => t.Id == teamId);
                if (team == null)
                {
                    continue;
                }

                leagueStandings.Add(new LeagueStandingVM
                {
                    TeamId = team.Id,
                    TeamName = team.Name,
                    TeamLogo = team.LogoUrl,
                    MatchesPlayed = matchesPlayed,
                    Wins = wins,
                    Losses = losses,
                    Draws = draws,
                    GoalsFor = GoalsFor,
                    GoalsAgainst = GoalsAgainst,
                    GoalDifference = goalDifference,
                    Points = (wins * 3) + draws
                });
            }

            var data = new CustomerHomeVM
            {
                LeagueStandings = leagueStandings.OrderByDescending(x => x.Points).ThenByDescending(x => x.GoalDifference).ThenByDescending(x => x.GoalsFor).ThenByDescending(x => x.MatchesPlayed).ToList(),
            };


            return View(data);
        }
    }
}
