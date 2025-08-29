using Azure.Core;
using CoreLayer.Helpers;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
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
    public class TeamController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;

        public TeamController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<IActionResult> Index(PageFilterVM filter)
        {
            Expression<Func<Team, bool>>? filterExpression = c => string.IsNullOrEmpty(filter.SearchTerm) || c.Name.Contains(filter.SearchTerm);
            var teams = await _unitOfWork.TeamRepository.GetAllAsync(
                filter: filterExpression,
                skip: filter.SkipNumber,
                take: filter.PageSize,
                orderBy: q => q.OrderByDescending(c => c.Id),
                includeChain: c => c.Include(t => t.Coach)
            );
            var data = new ModelsWithPaginationVM<Team>
            {
                Items = teams,
                Pagination = new PaginationVM
                {
                    PageNumber = filter.PageNumber ?? 1,
                    PageSize = filter.PageSize ?? 5,
                    TotalCount = await _unitOfWork.TeamRepository.CountAsync(filterExpression)
                }

            };
            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var viewModel = new CreateTeamVM
            {
                Founded = DateTime.Now,
                Coaches = (await _unitOfWork.CoachRepository.GetAllAsync())
                    .Select(c => new SelectListItem
                    {
                        Value = c.Id.ToString(),
                        Text = c.Name
                    }).ToList(),
                AvailablePlayers = (await _unitOfWork.PlayerRepository.GetAllAsync())
                    .Select(p => new SelectListItem
                    {
                        Value = p.Id.ToString(),
                        Text = p.Name
                    }).ToList(),
                SelectedPlayers = new List<CreateTeamVM.PlayerSelection>()
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateTeamVM createTeam, IFormFile LogoUrl)
        {
            // التحقق من إن الكابتن موجود ضمن اللاعبين المختارين
            if (createTeam.CaptainId != 0 && !createTeam.SelectedPlayers.Any(p => p.PlayerId == createTeam.CaptainId))
            {
                ModelState.AddModelError("CaptainId", "The selected captain must be one of the chosen players.");
            }
            ModelState.Remove("LogoUrl");
            if (!ModelState.IsValid)
            {
                createTeam.Coaches = (await _unitOfWork.CoachRepository.GetAllAsync())
                    .Select(c => new SelectListItem
                    {
                        Value = c.Id.ToString(),
                        Text = c.Name
                    }).ToList();
                createTeam.AvailablePlayers = (await _unitOfWork.PlayerRepository.GetAllAsync())
                    .Select(p => new SelectListItem
                    {
                        Value = p.Id.ToString(),
                        Text = p.Name
                    }).ToList();
                return View(createTeam);
            }
            if (createTeam.CoachesId.HasValue)
            {
                await RemoveCoachFromOldTeam(createTeam.CoachesId.Value);
            }
            // إنشاء الفريق
            var team = new Team
            {
                Name = createTeam.Name,
                Description = createTeam.Description,
                LogoUrl = createTeam.LogoUrl,
                Country = createTeam.Country,
                Founded = createTeam.Founded,
                CoachId = createTeam.CoachesId,
                Players = createTeam.SelectedPlayers.Select(p => new TeamPlayer
                {
                    PlayerId = p.PlayerId,
                    JoinedDate = p.JoinedDate,
                    Number = p.Number,
                    LeftDate = null,
                    IsCaptain = p.PlayerId == createTeam.CaptainId
                }).ToList()
            };
            // التعامل مع رفع ملف اللوجو
            if (LogoUrl != null && LogoUrl.Length > 0)
            {
                string fileName = FileHelper.CreateFileName(LogoUrl.FileName);
                var path = "assets\\images\\TeamsLogo";
                string filePath = FileHelper.GetFilePath(fileName, "wwwroot\\" + path);
                await FileHelper.UploadFile(filePath, LogoUrl);
                createTeam.LogoUrl = "/" + path.Replace("\\", "/") + "/" + fileName;
            }
            else
            {
                ModelState.AddModelError("ImgPath", "Image is required.");
                return View(createTeam);
            }
            // حفظ الفريق
            await _unitOfWork.TeamRepository.AddAsync(team);
            await _unitOfWork.TeamRepository.SaveChangesAsync();
            TempData["SuccessMessage"] = "Team created successfully.";
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var team = await _unitOfWork.TeamRepository.GetOneAsync(e => e.Id == id, includeChain: q => q.Include(t => t.Players).ThenInclude(tp => tp.Player));
            if (team is null)
            {
                return NotFound();
            }

            var viewModel = new EditTeamVM
            {
                Id = team.Id,
                Name = team.Name,
                Description = team.Description,
                LogoUrl = string.IsNullOrEmpty(team.LogoUrl) ? null : team.LogoUrl,
                Country = team.Country,
                Founded = team.Founded,
                CoachesId = team.CoachId,
                Coaches = (await _unitOfWork.CoachRepository.GetAllAsync())
                    .Select(c => new SelectListItem
                    {
                        Value = c.Id.ToString(),
                        Text = c.Name
                    }).ToList(),
                AvailablePlayers = (await _unitOfWork.PlayerRepository.GetAllAsync())
                    .Select(p => new SelectListItem
                    {
                        Value = p.Id.ToString(),
                        Text = p.Name
                    }).ToList(),
                SelectedPlayers = team.Players.Select(tp => new EditTeamVM.PlayerSelection
                {
                    PlayerId = tp.PlayerId,
                    JoinedDate = tp.JoinedDate,
                    Number = tp.Number,
                    IsCaptain = tp.IsCaptain
                }).ToList(),
                CaptainId = team.Players.FirstOrDefault(tp => tp.IsCaptain)?.PlayerId ?? 0
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditTeamVM editTeam, IFormFile LogoUrl)
        {
            if (editTeam.CaptainId != 0 && !editTeam.SelectedPlayers.Any(p => p.PlayerId == editTeam.CaptainId))
            {
                ModelState.AddModelError("CaptainId", "The selected captain must be one of the chosen players.");
            }
            ModelState.Remove("LogoUrl");
            if (!ModelState.IsValid)
            {
                editTeam.Coaches = (await _unitOfWork.CoachRepository.GetAllAsync())
                    .Select(c => new SelectListItem
                    {
                        Value = c.Id.ToString(),
                        Text = c.Name
                    }).ToList();
                editTeam.AvailablePlayers = (await _unitOfWork.PlayerRepository.GetAllAsync())
                    .Select(p => new SelectListItem
                    {
                        Value = p.Id.ToString(),
                        Text = p.Name
                    }).ToList();
                return View(editTeam);
            }
            var team = await _unitOfWork.TeamRepository.GetOneAsync(e => e.Id == editTeam.Id,
                includeChain: q => q.Include(t => t.Players));

            if (team is null)
            {
                return NotFound();
            }

            if (editTeam.CoachesId.HasValue)
            {
                await RemoveCoachFromOldTeam(editTeam.CoachesId.Value, editTeam.Id);
            }

            team.Name = editTeam.Name;
            team.Description = editTeam.Description;
            team.Country = editTeam.Country;
            team.Founded = editTeam.Founded;
            team.CoachId = editTeam.CoachesId;

            team.Players.Clear();
            team.Players = editTeam.SelectedPlayers.Select(p => new TeamPlayer
            {
                PlayerId = p.PlayerId,
                JoinedDate = p.JoinedDate,
                Number = p.Number,
                IsCaptain = p.PlayerId == editTeam.CaptainId
            }).ToList();

            if (LogoUrl != null && LogoUrl.Length > 0)
            {
                if (!string.IsNullOrEmpty(team.LogoUrl))
                {
                    var oldImagePath = Path.Combine("wwwroot", team.LogoUrl.TrimStart('/').Replace("/", "\\"));
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }
                string fileName = FileHelper.CreateFileName(LogoUrl.FileName);
                var path = "assets\\images\\TeamsLogo";
                string filePath = FileHelper.GetFilePath(fileName, "wwwroot\\" + path);
                await FileHelper.UploadFile(filePath, LogoUrl);
                team.LogoUrl = "/" + path.Replace("\\", "/") + "/" + fileName;
            }
            
            _unitOfWork.TeamRepository.Update(team);
            await _unitOfWork.TeamRepository.SaveChangesAsync();
            TempData["SuccessMessage"] = "Team Edit successfully.";
            return RedirectToAction(nameof(Index));
        }
    
        
        private async Task RemoveCoachFromOldTeam(int coachId, int currentTeam = 0)
        {
            var team = await _unitOfWork.TeamRepository.GetOneAsync(t => t.CoachId == coachId && t.Id !=  currentTeam);
            if(team != null)
            {
                team.CoachId = null;
                _unitOfWork.TeamRepository.Update(team);
                await _unitOfWork.TeamRepository.SaveChangesAsync();
            }
        }

        public async Task<IActionResult> Archive(int id)
        {
            var existingCoach = await _unitOfWork.TeamRepository.GetOneAsync(c => c.Id == id);
            if (existingCoach == null)
            {
                existingCoach = await _unitOfWork.TeamRepository.GetOneAsync(c => c.Id == id, IsDeleted: true);
                if (existingCoach == null)
                {
                    return NotFound();
                }
                await _unitOfWork.TeamRepository.AddToArchiveAsync(c => c.Id == id);
                await _unitOfWork.TeamRepository.SaveChangesAsync();
                TempData["SuccessMessage"] = "Team Removed from Archive successfully.";
                return RedirectToAction(nameof(Index));
            }

            await _unitOfWork.TeamRepository.AddToArchiveAsync(c => c.Id == id);
            await _unitOfWork.TeamRepository.SaveChangesAsync();
            TempData["SuccessMessage"] = "Team Moved To Archive successfully.";
            return RedirectToAction(nameof(Index));
        }

    }
}
