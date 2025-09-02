using Microsoft.Extensions.Logging;
using DataAccessLayer.Repositories.IRepositories;

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
                    m => m.Status == CoreLayer.Enums.MatchStatus.Scheduled
                );

                _logger.LogInformation("Found {count} scheduled matches", matches.Count());

                int touched = 0;

                foreach (var match in matches)
                {
                    var tickets = await _unitOfWork.TicketRepository.GetAllAsync(t => t.MatchId == match.Id);
                    if (!tickets.Any())
                    {
                        _logger.LogInformation("Match {matchId} - no tickets found", match.Id);
                        continue;
                    }

                    int totalTickets = tickets.Count();
                    int soldTickets = tickets.Count(t => t.isSold);

                    decimal newMatchPrice = CalculateTicketPrice(
                        match.TicketPrice,
                        totalTickets,
                        soldTickets,
                        match.MatchDate,
                        match.isBigMatch
                    );

                    if (newMatchPrice != match.TicketPrice)
                    {
                        _logger.LogInformation("Match {matchId}: {old} -> {new} (total={total}, sold={sold})",
                            match.Id, match.TicketPrice, newMatchPrice, totalTickets, soldTickets);

                        match.TicketPrice = newMatchPrice;
                        _unitOfWork.MatchRepository.Update(match);
                        touched++;
                    }
                    else
                    {
                        _logger.LogInformation("Match {matchId}: price unchanged ({price})", match.Id, match.TicketPrice);
                    }
                }

                if (touched > 0)
                {
                    await _unitOfWork.SaveChangesAsync();
                    _logger.LogInformation("Saved changes for {touched} matches", touched);
                }
                else
                {
                    _logger.LogInformation("No match prices changed.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "TicketPricingService failed");
                throw; // سيظهر في Hangfire Dashboard برضه
            }
        }

        private decimal CalculateTicketPrice(decimal basePrice, int totalTickets, int soldTickets, DateTime matchDate, bool isBigMatch)
        {
            decimal price = basePrice;
            double soldPercentage = totalTickets > 0 ? (double)soldTickets / totalTickets * 100 : 0;
            double hoursToMatch = (matchDate - DateTime.UtcNow).TotalHours;

            // الزيادات
            if (soldPercentage > 70) price += price * 0.20m;
            if (hoursToMatch <= 48) price += price * 0.15m;
            if (isBigMatch) price += price * 0.10m;

            // التخفيضات
            if (!isBigMatch && soldPercentage < 30) price -= price * 0.10m;
            if (soldTickets == 0 && hoursToMatch <= 72) price -= price * 0.20m;

            // حد أقصى وأدنى
            var maxPrice = basePrice * 1.50m; // +50%
            var minPrice = basePrice * 0.80m; // -20%

            if (price > maxPrice) price = maxPrice;
            if (price < minPrice) price = minPrice;

            return Math.Round(price, 2);
        }

    }
}
