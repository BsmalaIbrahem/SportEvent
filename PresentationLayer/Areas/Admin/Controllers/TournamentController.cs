using DataAccessLayer.Models;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using PresentationLayer.ViewModels;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class TournamentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public TournamentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index(PageFilterVM filter)
        {
            var tournaments = await _unitOfWork.TournamentRepository.GetAllAsync(
                skip: filter.SkipNumber,
                take: filter.PageSize,
                orderBy: q => q.OrderByDescending(c => c.Id)
            );
            var data = new ModelsWithPaginationVM<Tournament>
            {
                Items = tournaments,
                Pagination = new PaginationVM
                {
                    PageNumber = filter.PageNumber ?? 1,
                    PageSize = filter.PageSize ?? 5,
                    TotalCount = await _unitOfWork.TournamentRepository.CountAsync()
                }

            };
            return View(data);
        }
    
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTournamentVM tournament)
        {
            
            if (!ModelState.IsValid)
            {
                return View(tournament);
            }
            var existingTournament = await _unitOfWork.TournamentRepository.GetOneAsync(t => t.Title == tournament.Title && t.Season == tournament.Season);
            if (existingTournament != null)
            {
                ModelState.AddModelError("", "A tournament with the same title and season already exists.");
                return View(tournament);
            }

            if (tournament.StartDate >= tournament.EndDate)
            {
                ModelState.AddModelError("EndDate", "End date must be after the start date.");
                return View(tournament);
            }

            var newTournament = new Tournament
            {
                Title = tournament.Title,
                Description = tournament.Description,
                Season = tournament.Season,
                StartDate = tournament.StartDate,
                EndDate = tournament.EndDate,
                Venue = tournament.Venue,
                Type = tournament.Type
            };
            await _unitOfWork.TournamentRepository.AddAsync(newTournament);
            await _unitOfWork.TournamentRepository.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var existingTournament = await _unitOfWork.TournamentRepository.GetOneAsync(e=>e.Id == id);
            if (existingTournament is null)
            {
                return NotFound();
            }

            var editTournament = new CreateTournamentVM
            {
                Title = existingTournament.Title,
                Description= existingTournament.Description,
                Season = existingTournament.Season,
                StartDate = existingTournament.StartDate,
                EndDate = existingTournament.EndDate,
                Venue= existingTournament.Venue,
                Type = existingTournament.Type
            };
            return View(editTournament);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,CreateTournamentVM tournament)
        {
            if (!ModelState.IsValid)
            {
                return View(tournament);
            }

            var editTM = await _unitOfWork.TournamentRepository.GetOneAsync(e=> e.Id == id);
            
            if (editTM is null)
            {
                return NotFound();
            }

            if(tournament.StartDate >= tournament.EndDate)
            {
                ModelState.AddModelError("EndDate", "EndDate Must Be After the StartDate");
                return View(tournament);
            }

            var duplicateTournament = await _unitOfWork.TournamentRepository.GetOneAsync
                (t => t.Title == tournament.Title && t.Season == tournament.Season && t.Id != id);

            if (duplicateTournament is not null)
            {
                ModelState.AddModelError("", "A tournament with the same title and season already exists.");
                return View(tournament);
            }

            editTM.Title = tournament.Title;
            editTM.Description = tournament.Description;
            editTM.Season = tournament.Season;
            editTM.StartDate = tournament.StartDate;
            editTM.EndDate = tournament.EndDate;
            editTM.Venue = tournament.Venue;
            editTM.Type = tournament.Type;

            _unitOfWork.TournamentRepository.Update(editTM);
            await _unitOfWork.TournamentRepository.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
