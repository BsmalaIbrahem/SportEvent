using CoreLayer.Enums;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.AspNetCore.Authorization;
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
        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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

            var data = new DashboardVM
            {
                TotalMatches = totalMaches,
                TotalUpcomingMatches = totalUpcomingMatches,
                TotalFinishedMatches = totalFinishedMatches,
                TotalTeams = totlTeams
            };

            return View(data);
        }
    }
}
