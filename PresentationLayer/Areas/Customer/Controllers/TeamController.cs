using CoreLayer.Enums;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class TeamController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public TeamController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var teams = await _unitOfWork.TeamRepository.GetAllAsync(
                includeChain: q => q
                    .Include(t => t.Coach)
                    .Include(t => t.Players)
            );

            if (teams == null || !teams.Any())
                return NotFound("There's no teams founded");

            return View(teams);
        }

        public async Task<IActionResult> Details(int id)
        {
            var team = await _unitOfWork.TeamRepository.GetOneAsync(
                t => t.Id == id,
                includeChain: q => q
                    .Include(t => t.Coach)
                    .Include(t => t.Players)
                    .ThenInclude(tp => tp.Player)
            );

            if (team is null)
                return NotFound();

            var teamMatches = await _unitOfWork.MatchRepository.GetAllAsync(
                m => m.Status == MatchStatus.Finished &&
                    (m.HomeTeamId == id || m.AwayTeamId == id),
                includeChain: q => q
                    .Include(m => m.HomeTeam)
                    .Include(m => m.AwayTeam)
                    .Include(m => m.Tournament)
            );

            ViewData["TeamMatches"] = teamMatches;

            return View(team);
        }
    }
}
