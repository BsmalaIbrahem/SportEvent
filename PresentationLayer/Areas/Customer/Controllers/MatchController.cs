using CoreLayer.Enums;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PresentationLayer.ViewModels;
using System.Linq;

namespace PresentationLayer.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class MatchController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public MatchController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index()
        {

            //Currren tMatch
            var currentMatch = await _unitOfWork.MatchRepository.GetOneAsync(
                m => m.Status == MatchStatus.InProgress,
                includeChain: q => q.Include(m => m.HomeTeam)
                                    .Include(m => m.AwayTeam)
                                    .Include(t => t.Tournament)
            );


            if (currentMatch is null)
            {
                    currentMatch = await _unitOfWork.MatchRepository.GetOneAsync(
                     m => m.Status == CoreLayer.Enums.MatchStatus.Finished,
                     includeChain: q => q.Include(m => m.HomeTeam)
                     .Include(m => m.AwayTeam)
                     .Include(t => t.Tournament)
                    );
            }

            List<TeamPlayer> players = new List<TeamPlayer>();
            if (currentMatch != null)
            {
                players = (List<TeamPlayer>)await _unitOfWork.TeamPlayerRepository.GetAllAsync(
                    tp => tp.TeamId == currentMatch.HomeTeamId || tp.TeamId == currentMatch.AwayTeamId,
                    includeChain: q => q.Include(tp => tp.Player),
                    take: 8
                );
            }


            //Next Match
            var nextMatch = await _unitOfWork.MatchRepository.GetOneAsync(
            m => m.Status == MatchStatus.Scheduled,
            includeChain: q => q.Include(m => m.HomeTeam)
            .Include(m => m.AwayTeam)
            .Include(t => t.Tournament),
            orderBy: q => q.OrderBy(m => m.MatchDate)
            );

            //Upcoming Matches
            
            var upcomingMatches = await _unitOfWork.MatchRepository.GetAllAsync(
            m => m.Status == MatchStatus.Scheduled,
            includeChain: q => q.Include(m => m.HomeTeam)
            .Include(m => m.AwayTeam)
            .Include(t => t.Tournament),
            orderBy: q => q.OrderBy(m => m.MatchDate),
            skip : 0,
            take: 4
            );


            var matchPage = new MatchPageVM
            {
                CurrentMatch = currentMatch,
                TeamPlayer = players,
                NextMatch = nextMatch,
                UpcomingMatches = upcomingMatches?.ToList() ?? new List<Match>()
            };

            return View(matchPage);
        }
    }
}
