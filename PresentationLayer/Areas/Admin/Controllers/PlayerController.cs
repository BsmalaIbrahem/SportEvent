using CoreLayer.Helpers;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.ViewModels;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class PlayerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public PlayerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index(PageFilterVM filter)
        {
            Expression<Func<Player, bool>>? filterExpression = c => string.IsNullOrEmpty(filter.SearchTerm) || c.Name.Contains(filter.SearchTerm);
            var players = await _unitOfWork.PlayerRepository.GetAllAsync(
                filter: filterExpression,
                skip: filter.SkipNumber,
                take: filter.PageSize,
                orderBy: q => q.OrderByDescending(c => c.Id),
                includeChain: q => q.Include(c => c.Teams).ThenInclude(t => t.Team)
            );
            var data = new ModelsWithPaginationVM<Player>
            {
                Items = players,
                Pagination = new PaginationVM
                {
                    PageNumber = filter.PageNumber ?? 1,
                    PageSize = filter.PageSize ?? 5,
                    TotalCount = await _unitOfWork.PlayerRepository.CountAsync(filterExpression)
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
        public async Task<IActionResult> Create(CreatePlayerVM request, IFormFile ImgPath)
        {
            if (!ModelState.IsValid)
            {
                await SetViewBag(request.TeamId);
                return View(request);
            }

            if(!IsValidPlayerAge(request.DateOfBirth))
            {
                await SetViewBag(request.TeamId);
                ModelState.AddModelError("DateOfBirth", "Date Of Birth is InValid");
                return View(request);
            }

            if (request.Number != null &&  ! await IsValidTShirtNumber(request.TeamId, request.Number ?? 1))
            {
                await SetViewBag(request.TeamId);
                ModelState.AddModelError("Number", "T-Shirt Number is already taken in this team.");
                return View(request);
            }

            var player = new Player
            {
                Name = request.Name,
                Description = request.Description,
                Nationality = request.Nationality,
                DateOfBirth = request.DateOfBirth,
                Position = request.Position,

                Teams = new List<TeamPlayer> { new TeamPlayer { 
                    TeamId = request.TeamId, 
                    Number =  request.Number,
                    JoinedDate = request.JoinedDate,
                    IsCaptain = request.IsCaptain
                }}
            };

            if (ImgPath != null && ImgPath.Length > 0)
            {
                string fileName = FileHelper.CreateFileName(ImgPath.FileName);
                var path = "assets\\images\\players";
                string filePath = FileHelper.GetFilePath(fileName, "wwwroot\\" + path);
                await FileHelper.UploadFile(filePath, ImgPath);
                player.ImgPath = "/" + path.Replace("\\", "/") + "/" + fileName;
            }
            else
            {
                await SetViewBag(request.TeamId);
                ModelState.AddModelError("ImgPath", "Image is required.");
                return View(request);
            }

            await _unitOfWork.PlayerRepository.AddAsync(player);
            await _unitOfWork.PlayerRepository.SaveChangesAsync();

            TempData["SuccessMessage"] = "Coach created successfully.";
            return RedirectToAction(nameof(Index));
        }


        private async Task SetViewBag(int selectedTemaId = 1)
        {
            var teams = await _unitOfWork.TeamRepository.GetAllAsync();
            ViewBag.Teams = new SelectList(teams, "Id", "Name", selectedTemaId);

        }


        private bool IsValidPlayerAge(DateTime birthDate)
        {
            var age = DateTime.Now.Year - birthDate.Year;
            if(age <=12)
            {
                return false;
            }
            return true;
        }

        private async Task<bool> IsValidTShirtNumber(int teamId, int tshirtNumber, int playerId = 0)
        {
            var existingPlayer = await _unitOfWork.TeamPlayerRepository.GetOneAsync(x => x.TeamId == teamId && x.Number == tshirtNumber && x.LeftDate == null && x.PlayerId != playerId);
            if(existingPlayer != null)
            {
                return false;
            }
            return true;
        }


        public async Task<IActionResult> Edit(int id)
        {
            var player = await _unitOfWork.PlayerRepository.GetOneAsync(
                e => e.Id == id,
                includeChain: q => q.Include(p => p.Teams).ThenInclude(tp => tp.Team)
            );

            if (player is null)
            {
                return NotFound();
            }

            var teamPlayer = player.Teams.FirstOrDefault(tp => tp.LeftDate == null);

            var playerVm = new CreatePlayerVM
            {
                Name = player.Name,
                Description = player.Description,
                Nationality = player.Nationality,
                ImgPath = player.ImgPath!,
                DateOfBirth = player.DateOfBirth,
                Position = player.Position,
                TeamId = teamPlayer?.TeamId ?? 0,
                Number = teamPlayer?.Number,
                IsCaptain = teamPlayer?.IsCaptain ?? false,
                JoinedDate = teamPlayer?.JoinedDate ?? DateTime.Now
            };

            await SetViewBag(playerVm.TeamId);
            return View(playerVm);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, CreatePlayerVM request, IFormFile? ImgPath)
        {
            if (!ModelState.IsValid)
            {
                await SetViewBag(request.TeamId);
                return View(request);
            }

            var player = await _unitOfWork.PlayerRepository.GetOneAsync(e => e.Id == id);
            if (player is null)
            {
                return NotFound();
            }

            if (request.Number != null && !await IsValidTShirtNumber(request.TeamId, request.Number ?? 1, id))
            {
                await SetViewBag(request.TeamId);
                ModelState.AddModelError("Number", "T-Shirt Number is already taken in this team.");
                return View(request);
            }

            player.Name = request.Name;
            player.Description = request.Description;
            player.Nationality = request.Nationality;
            player.DateOfBirth = request.DateOfBirth;
            player.Position = request.Position;

            var teamPlayer = player.Teams.FirstOrDefault(tp => tp.TeamId == request.TeamId && tp.LeftDate == null);
            if (teamPlayer != null)
            {
                teamPlayer.Number = request.Number;
                teamPlayer.JoinedDate = request.JoinedDate;
                teamPlayer.IsCaptain = request.IsCaptain;
            }

            // Image Update
            if (ImgPath != null && ImgPath.Length > 0)
            {
                if (!string.IsNullOrEmpty(player.ImgPath))
                {
                    var oldImagePath = Path.Combine("wwwroot", player.ImgPath.TrimStart('/').Replace("/", "\\"));
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }
                string fileName = FileHelper.CreateFileName(ImgPath.FileName);
                var path = "assets\\images\\players";
                string filePath = FileHelper.GetFilePath(fileName, "wwwroot\\" + path);
                await FileHelper.UploadFile(filePath, ImgPath);
                player.ImgPath = "/" + path.Replace("\\", "/") + "/" + fileName;
            }

            _unitOfWork.PlayerRepository.Update(player);
            await _unitOfWork.PlayerRepository.SaveChangesAsync();

            TempData["SuccessMessage"] = "Player updated successfully.";
            return RedirectToAction(nameof(Index));
        }
    }
}
