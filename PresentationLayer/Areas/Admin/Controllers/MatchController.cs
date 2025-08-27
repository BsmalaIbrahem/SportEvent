using DataAccessLayer.Models;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using PresentationLayer.ViewModels;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class MatchController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public MatchController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index(PageFilterVM filter)
        {
            var matches = await _unitOfWork.MatchRepository.GetAllAsync(
                skip: filter.SkipNumber,
                take: filter.PageSize,
                orderBy: q => q.OrderByDescending(c => c.Id),
                includeChain: q => q.Include(c => c.Tournament).Include(c => c.AwayTeam).Include(c => c.HomeTeam)
            );
            var data = new ModelsWithPaginationVM<Match>
            {
                Items = matches,
                Pagination = new PaginationVM
                {
                    PageNumber = filter.PageNumber ?? 1,
                    PageSize = filter.PageSize ?? 5,
                    TotalCount = await _unitOfWork.MatchRepository.CountAsync()
                }

            };
            return View(data);
        }

        public async Task<IActionResult> Create()
        {
            await SetViewBag();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateMatchVM request)
        {
            if (!ModelState.IsValid)
            {
                await SetViewBag(request.HomeTeamId);
                return View(request);
            }

            if (request.HomeTeamId == request.AwayTeamId)
            {
                ModelState.AddModelError("HomeTeamId", "Home team and away team cannot be the same.");
                await SetViewBag(request.HomeTeamId);
                return View(request);
            }

            if (request.MatchDate < DateTime.Now && request.MatchStatus == CoreLayer.Enums.MatchStatus.Scheduled)
            {
                ModelState.AddModelError("MatchDate", "Match date cannot be in the past if the match is scheduled.");
                await SetViewBag(request.HomeTeamId);
                return View(request);
            }

            if(request.MatchDate > DateTime.Now && (request.HomeScore > 0 || request.AwayScore > 0))
            {
                ModelState.AddModelError("MatchDate", "Match date cannot be in the future if scores are provided.");
                await SetViewBag(request.HomeTeamId);
                return View(request);
            }

            var match = new Match
            {
                HomeTeamId = request.HomeTeamId,
                AwayTeamId = request.AwayTeamId,
                TournamentId = request.TournamentId,
                MatchDate = request.MatchDate,
                Location = request.Location,
                Status = request.MatchStatus,
                HomeScore = request.HomeScore,
                AwayScore = request.AwayScore,
                AvailableTickets = request.AvailableTickets

            };

            await _unitOfWork.MatchRepository.AddAsync(match);
            await _unitOfWork.MatchRepository.SaveChangesAsync();
            TempData["SuccessMessage"] = "Match created successfully.";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var match = await _unitOfWork.MatchRepository.GetOneAsync(x => x.Id == id);
            if (match == null)
            {
                return NotFound();
            }

            var model = new EditMatchVM
            {
                Id = match.Id,
                HomeTeamId = match.HomeTeamId,
                AwayTeamId = match.AwayTeamId,
                TournamentId = match.TournamentId,
                MatchDate = match.MatchDate,
                Location = match.Location,
                MatchStatus = match.Status,
                HomeScore = match.HomeScore,
                AwayScore = match.AwayScore,
                AvailableTickets = match.AvailableTickets
            };

            await SetViewBag();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditMatchVM request)
        {
            if (!ModelState.IsValid)
            {
                await SetViewBag(request.HomeTeamId, request.TournamentId);
                return View(request);
            }
            if (request.HomeTeamId == request.AwayTeamId)
            {
                ModelState.AddModelError("HomeTeamId", "Home team and away team cannot be the same.");
                await SetViewBag(request.HomeTeamId, request.TournamentId);
                return View(request);
            }
            if (request.MatchDate < DateTime.Now && request.MatchStatus == CoreLayer.Enums.MatchStatus.Scheduled)
            {
                ModelState.AddModelError("MatchDate", "Match date cannot be in the past if the match is scheduled.");
                await SetViewBag(request.HomeTeamId, request.TournamentId);
                return View(request);
            }
            if (request.MatchDate > DateTime.Now && (request.HomeScore > 0 || request.AwayScore > 0))
            {
                ModelState.AddModelError("MatchDate", "Match date cannot be in the future if scores are provided.");
                await SetViewBag(request.HomeTeamId, request.TournamentId);
                return View(request);
            }
            var match = await _unitOfWork.MatchRepository.GetOneAsync(x => x.Id == request.Id, asNoTracking: true);
            if (match == null)
            {
                return NotFound();
            }
            match.HomeTeamId = request.HomeTeamId;
            match.AwayTeamId = request.AwayTeamId;
            match.TournamentId = request.TournamentId;
            match.MatchDate = request.MatchDate;
            match.Location = request.Location;
            match.Status = request.MatchStatus;
            match.HomeScore = request.HomeScore;
            match.AwayScore = request.AwayScore;
            match.AvailableTickets = request.AvailableTickets;
            _unitOfWork.MatchRepository.Update(match);
            await _unitOfWork.MatchRepository.SaveChangesAsync();
            TempData["SuccessMessage"] = "Match Edited successfully.";
            return RedirectToAction(nameof(Index));
        }


        private async Task SetViewBag(int selectedTemaId = 1, int selectedTournament = 1)
        {
            var tournaments = await _unitOfWork.TournamentRepository.GetAllAsync();
            ViewBag.Tournaments = new SelectList(tournaments, "Id", "Title", selectedTournament);

            var teams = await _unitOfWork.TeamRepository.GetAllAsync();
            ViewBag.Teams = new SelectList(teams, "Id", "Name", selectedTemaId);

        }



    }
}
