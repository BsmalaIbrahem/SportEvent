using CoreLayer.Enums;
using DataAccessLayer.Data;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.ViewModels;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin,SuperAdmin")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        public HomeController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }

        public async Task<IActionResult> Dashboard(DashboardFilterVM filter)
        {
            var Tournment = await _unitOfWork.TournamentRepository.GetOneAsync(t => t.Title == filter.Title && t.Season == filter.Season);
            if (Tournment == null)
            {
                ModelState.AddModelError("", "No tournament found with the specified title and season.");
                return View(new DashboardFilterVM());
            }

            var totalMaches = await _unitOfWork.MatchRepository.CountAsync(m => m.TournamentId == Tournment.Id);
            var totalUpcomingMatches = await _unitOfWork.MatchRepository.CountAsync(m => m.TournamentId == Tournment.Id && m.MatchDate > DateTime.Now && m.Status == MatchStatus.Scheduled);
            var totalFinishedMatches = await _unitOfWork.MatchRepository.CountAsync(m => m.TournamentId == Tournment.Id && m.Status == MatchStatus.Finished);
           
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
            var totlTeams = teams.Count;
            var leagueStandings = new List<LeagueStandingVM>();

            foreach (var teamId in teams) 
            {
                var matchesPlayed = await _unitOfWork.MatchRepository.CountAsync(x => x.TournamentId == Tournment.Id && x.Status != MatchStatus.Scheduled && (x.HomeTeamId == teamId || x.AwayTeamId == teamId));
                var wins = await _unitOfWork.MatchRepository.CountAsync(x => x.TournamentId == Tournment.Id && x.Status != MatchStatus.Scheduled && ((x.HomeTeamId == teamId && x.HomeScore > x.AwayScore) || (x.AwayTeamId == teamId && x.HomeScore < x.AwayScore)));
                var losses = await _unitOfWork.MatchRepository.CountAsync(x => x.TournamentId == Tournment.Id && x.Status != MatchStatus.Scheduled && ((x.HomeTeamId == teamId && x.HomeScore < x.AwayScore) || (x.AwayTeamId == teamId && x.HomeScore > x.AwayScore)));
                var draws = await _unitOfWork.MatchRepository.CountAsync(x => x.TournamentId == Tournment.Id && x.Status != MatchStatus.Scheduled && ((x.HomeTeamId == teamId && x.HomeScore == x.AwayScore) || (x.AwayTeamId == teamId && x.HomeScore == x.AwayScore)));

                int GoalsFor = 0, GoalsAgainst = 0;
                var homeMatches =await _unitOfWork.MatchRepository.GetAllAsync(x => x.TournamentId == Tournment.Id && x.Status != MatchStatus.Scheduled && x.HomeTeamId == teamId);
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
                    Points= (wins * 3) + draws
                });
            }


            var soldTickets = await _unitOfWork.TicketRepository.GetAllAsync(
                t => t.Status == TicketStatus.Confirmed ,
                includeChain: q => q.Include(t => t.TicketMatches).Include(t => t.User),
                orderBy: x => x.OrderByDescending(x => x.Id)
              );

            var expectUsers = await _userManager.GetUsersInRoleAsync("SuperAdmin");
            var users = await _userManager.Users.Where(x => !expectUsers.Select(e => e.Id).Contains(x.Id)).CountAsync();
           

            var data = new DashboardVM
            {
                TotalMatches = totalMaches,
                TotalUpcomingMatches = totalUpcomingMatches,
                TotalFinishedMatches = totalFinishedMatches,
                TotalTeams = totlTeams,
                LeagueStandings = leagueStandings.OrderByDescending(x => x.Points).ThenByDescending(x => x.GoalDifference).ThenByDescending(x => x.GoalsFor).ThenByDescending(x => x.MatchesPlayed).ToList(),
                DrawsCount = leagueStandings.Sum(x => x.Draws) / 2,
                WinsCount = leagueStandings.Sum(x => x.Wins),
                TotalTicketsSold = soldTickets.SelectMany(t => t.TicketMatches).Sum(tm => tm.Quantity),
                TotalRevenue = soldTickets.Sum(t => t.SubTotal - t.Discount),
                TotalUsers = users,
                ActiveUsers = soldTickets.Select(t => t.UserId).Distinct().Count(),
                TeamsWithTickets = await TeamsWithTickets(Tournment.Id),
                TicketsWithTypes = await TicketsWithTypes()
            };
            
            return View(data);
        }

        private async Task<List<TeamsWithTicketsVM>> TeamsWithTickets(int tournmentId)
        {
            var matches = await _unitOfWork.MatchRepository.GetAllAsync(m => m.TournamentId == tournmentId,
                                                                            includeChain: q=>q.Include(m => m.HomeTeam)
                                                                                                .Include(m => m.AwayTeam)
                                                                   );
            var teams = matches.SelectMany(m => new[] { m.HomeTeam, m.AwayTeam }).Distinct().ToList();
            var teamWithTickets = new List<TeamsWithTicketsVM>();
            foreach (var team in teams) 
            {
                var soldTickets = await _unitOfWork.TicketMatchRepository.GetAllAsync(x => x.TeamId == team.Id && x.Ticket.Status == TicketStatus.Confirmed, includeChain: q=>q.Include(m => m.Ticket));
                teamWithTickets.Add(new TeamsWithTicketsVM
                {
                    TeamId = team.Id,
                    TeamName = team.Name,
                    TeamLogoUrl = team.LogoUrl,
                    TicketsSold = soldTickets.Sum(x => x.Quantity)
                });
            }

            teamWithTickets = teamWithTickets.OrderByDescending(t => t.TicketsSold).ToList();
            return teamWithTickets;

        }
    
        
        private async Task<List<TicketsWithTypesVM>> TicketsWithTypes()
        {
            var ticketsWihTypes = new List<TicketsWithTypesVM>();
            foreach(var type in Enum.GetNames(typeof(TicketCategory)))
            {
                var tickets = await _unitOfWork.TicketMatchRepository.GetAllAsync(t => t.Ticket.Status == TicketStatus.Confirmed && t.Category.ToString() == type, includeChain: q => q.Include(t => t.Ticket));
                ticketsWihTypes.Add(new TicketsWithTypesVM
                {
                    TicketType = type,
                    TicketsSold = tickets.Sum(t => t.Quantity)
                });

            }
            
            return ticketsWihTypes;
        }

    }
}
