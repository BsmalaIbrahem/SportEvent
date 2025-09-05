using DataAccessLayer.Models;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace PresentationLayer.HostedServices
{
    public class TicketPricingService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<TicketPricingService> _logger;

        public TicketPricingService(IUnitOfWork unitOfWork, ILogger<TicketPricingService> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task UpdateTicketPricesAsync()
        {
            try
            {
                _logger.LogInformation("TicketPricingService started at {time}", DateTime.UtcNow);

                var matches = await _unitOfWork.MatchRepository.GetAllAsync(
                    m => m.Status == CoreLayer.Enums.MatchStatus.Scheduled,
                    includeChain: q => q
                        .Where(m => m.IsBookable)
                        .Include(m => m.TicketPrices)
                        .Include(t => t.Tournament)
                );

                _logger.LogInformation("Found {count} scheduled matches", matches.Count());

                int touched = 0;

                foreach (var match in matches)
                {
                    foreach (var ticketPrice in match.TicketPrices)
                    {
                        // عدد التذاكر الإجمالي
                        int totalTickets = ticketPrice.HomeTickets + ticketPrice.AwayTickets;

                        // عدد التذاكر المباعة (من جدول Ticket)
                        var soldTickets = await _unitOfWork.TicketRepository.CountAsync(
                            t => t.MatchId == match.Id
                              && t.Category == ticketPrice.Category
                              && t.Status == CoreLayer.Enums.TicketStatus.Confirmed
                        );

                        decimal newPrice = CalculateTicketPrice(
                            ticketPrice.Price,
                            totalTickets,
                            soldTickets,
                            match.MatchDate,
                            isBigMatch: match.isBigMatch
                        );

                        if (newPrice != ticketPrice.Price)
                        {
                            _logger.LogInformation(
                                "Match {matchId}, Category {cat}: {old} -> {new} (total={total}, sold={sold})",
                                match.Id, ticketPrice.Category, ticketPrice.Price, newPrice, totalTickets, soldTickets
                            );

                            ticketPrice.Price = newPrice;
                            _unitOfWork.TicketPriceRepository.Update(ticketPrice);
                            touched++;
                        }
                    }
                }

                if (touched > 0)
                {
                    await _unitOfWork.SaveChangesAsync();
                    _logger.LogInformation("Saved changes for {touched} ticket categories", touched);
                }
                else
                {
                    _logger.LogInformation("No ticket prices changed.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "TicketPricingService failed");
                throw;
            }
        }

        private decimal CalculateTicketPrice(decimal basePrice, int totalTickets, int soldTickets, DateTime matchDate, bool isBigMatch)
        {
            decimal price = basePrice;
            double soldPercentage = totalTickets > 0 ? (double)soldTickets / totalTickets * 100 : 0;
            double hoursToMatch = (matchDate - DateTime.UtcNow).TotalHours;

            // زيادات
            if (soldPercentage > 70) price += price * 0.20m;
            if (hoursToMatch <= 48) price += price * 0.15m;
            if (isBigMatch) price += price * 0.10m;

            // تخفيضات
            if (!isBigMatch && soldPercentage < 30) price -= price * 0.10m;
            if (soldTickets == 0 && hoursToMatch <= 72) price -= price * 0.20m;

            // الحد الأقصى والأدنى
            var maxPrice = basePrice * 1.50m; // +50%
            var minPrice = basePrice * 0.80m; // -20%

            if (price > maxPrice) price = maxPrice;
            if (price < minPrice) price = minPrice;

            return Math.Round(price, 2);
        }
    }
}
