using CoreLayer.Enums;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NuGet.Protocol.Core.Types;
using PresentationLayer.ViewModels;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

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

            // Get all matches that need status updates
            var matchesToUpdate = await _unitOfWork.MatchRepository.GetAllAsync(
                m => (m.Status == MatchStatus.Scheduled && m.MatchDate <= DateTime.UtcNow) ||
                     (m.Status == MatchStatus.InProgress && DateTime.UtcNow > m.MatchDate.AddHours(3))
            );

            foreach (var match in matchesToUpdate)
            {
                if (match.Status == MatchStatus.Scheduled && match.MatchDate <= DateTime.UtcNow)
                {
                    // Start match
                    match.Status = MatchStatus.InProgress;
                }
                else if (match.Status == MatchStatus.InProgress && DateTime.UtcNow > match.MatchDate.AddHours(3))
                {
                    // End match
                    match.Status = MatchStatus.Finished;
                }
                _unitOfWork.MatchRepository.Update(match);
            }

            if (matchesToUpdate.Any())
            {
                await _unitOfWork.MatchRepository.SaveChangesAsync();
            }

            // Now fetch current match (InProgress one)
            var currentMatch = await _unitOfWork.MatchRepository.GetOneAsync(
                m => m.Status == MatchStatus.InProgress,
                includeChain: q => q.Include(m => m.HomeTeam)
                                    .Include(m => m.AwayTeam)
                                    .Include(t => t.Tournament)
            );

            if (currentMatch == null)
            {
                    currentMatch = await _unitOfWork.MatchRepository.GetOneAsync(
                     m => m.Status == CoreLayer.Enums.MatchStatus.Finished,
                     orderBy: x => x.OrderByDescending(x => x.MatchDate),
                     includeChain: q => q.Include(m => m.HomeTeam)
                     .Include(m => m.AwayTeam)
                     .Include(t => t.Tournament)
                    );

                // If no current match, get last finished match
                currentMatch = await _unitOfWork.MatchRepository.GetOneAsync(
                    m => m.Status == MatchStatus.Finished,
                    orderBy: x => x.OrderByDescending(x => x.MatchDate),
                    includeChain: q => q.Include(m => m.HomeTeam)
                                        .Include(m => m.AwayTeam)
                                        .Include(t => t.Tournament)
                );
            }

            // Get Players
            List<TeamPlayer> players = new List<TeamPlayer>();
            if (currentMatch != null)
            {
                players = (List<TeamPlayer>)await _unitOfWork.TeamPlayerRepository.GetAllAsync(
                    tp => tp.TeamId == currentMatch.HomeTeamId || tp.TeamId == currentMatch.AwayTeamId,
                    includeChain: q => q.Include(tp => tp.Player),
                    take: 8
                );
            }

            // match Statistic
            List<MatchStatistic> goals = new List<MatchStatistic>();
            if (currentMatch != null)
            {
                goals = (List<MatchStatistic>)await _unitOfWork.MatchStatisticRepository.GetAllAsync(
                    s => s.MatchId == currentMatch.Id &&
                        (s.Type == StatisticType.Goal || s.Type == StatisticType.OwnGoal),
                    includeChain: q => q.Include(s => s.Player)
                                        .Include(s => s.Team)
                );
            }

            // Next Match
            var nextMatch = await _unitOfWork.MatchRepository.GetOneAsync(
                m => m.Status == MatchStatus.Scheduled && m.MatchDate > DateTime.UtcNow,
                includeChain: q => q.Include(m => m.HomeTeam)
                                    .Include(m => m.AwayTeam)
                                    .Include(t => t.Tournament),
                orderBy: q => q.OrderBy(m => m.MatchDate)
            );

            // Upcoming Matches
            var upcomingMatches = await _unitOfWork.MatchRepository.GetAllAsync(
                m => m.Status == MatchStatus.Scheduled && m.MatchDate > DateTime.UtcNow,
                includeChain: q => q.Include(m => m.HomeTeam)
                                    .Include(m => m.AwayTeam)
                                    .Include(t => t.Tournament),
                orderBy: q => q.OrderBy(m => m.MatchDate),
                skip: 1,
                take: 4
            );

            var matchPage = new MatchPageVM
            {
                CurrentMatch = currentMatch,
                TeamPlayer = players,
                Goals = goals,
                NextMatch = nextMatch,
                UpcomingMatches = upcomingMatches?.ToList() ?? new List<Match>()
            };

            return View(matchPage);

        }
    
        
        public async Task<IActionResult> AvailableForBooking(PageFilterVM filter)
        {
            Expression<Func<Match, bool>>? filterExpression = m => DateOnly.FromDateTime(m.MatchDate) > DateOnly.FromDateTime(DateTime.Now)
                                                                    && m.IsBookable == true;

            var matches = await _unitOfWork.MatchRepository.GetAllAsync(
                                                     filter: filterExpression,
                                                     includeChain: q => q.Include(m => m.HomeTeam)
                                                                        .Include(m => m.AwayTeam)
                                                                        .Include(t => t.Tournament)
                                                                        .Include(t => t.TicketPrices),
                                                    skip: filter.SkipNumber, take: filter.PageSize,
                                                    orderBy: q => q.OrderBy(m => m.MatchDate)
                                       );

            var data = new ModelsWithPaginationVM<Match>
            {
                Items = matches,
                Pagination = new PaginationVM
                {
                    PageNumber = filter.PageNumber ?? 1,
                    PageSize = filter.PageSize ?? 5,
                    TotalCount = await _unitOfWork.MatchRepository.CountAsync(filterExpression)
                }

            };

            return View(data);
        }

    }
}
