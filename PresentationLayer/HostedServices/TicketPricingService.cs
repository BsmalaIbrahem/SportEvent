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
                            ticketPrice.BasePrice,
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
            double daysToMatch = hoursToMatch / 24;

            // عوامل الطلب (زيادة السعر)
            decimal demandMultiplier = 1.0m;

            // 1. عامل نسبة البيع (كلما زادت نسبة البيع، زاد السعر)
            if (soldPercentage >= 90) demandMultiplier += 0.30m;        // +30% إذا كان البيع 90%+
            else if (soldPercentage >= 80) demandMultiplier += 0.20m;   // +20% إذا كان البيع 80%+
            else if (soldPercentage >= 70) demandMultiplier += 0.15m;   // +15% إذا كان البيع 70%+
            else if (soldPercentage >= 60) demandMultiplier += 0.10m;   // +10% إذا كان البيع 60%+
            else if (soldPercentage >= 50) demandMultiplier += 0.05m;   // +5% إذا كان البيع 50%+

            // 2. عامل الوقت المتبقي (كلما اقترب موعد المباراة، زاد السعر)
            if (hoursToMatch <= 6) demandMultiplier += 0.25m;           // +25% إذا بقي أقل من 6 ساعات
            else if (hoursToMatch <= 12) demandMultiplier += 0.20m;     // +20% إذا بقي أقل من 12 ساعة
            else if (hoursToMatch <= 24) demandMultiplier += 0.15m;     // +15% إذا بقي أقل من 24 ساعة
            else if (hoursToMatch <= 48) demandMultiplier += 0.10m;     // +10% إذا بقي أقل من 48 ساعة
            else if (hoursToMatch <= 72) demandMultiplier += 0.05m;     // +5% إذا بقي أقل من 72 ساعة

            // 3. عامل أهمية المباراة
            if (isBigMatch) demandMultiplier += 0.20m;                  // +20% للمباريات الكبيرة

            // 4. عامل اليوم (زيادة الطلب في عطلات نهاية الأسبوع)
            bool isWeekend = matchDate.DayOfWeek == DayOfWeek.Friday ||
                             matchDate.DayOfWeek == DayOfWeek.Saturday;
            if (isWeekend) demandMultiplier += 0.10m;                   // +10% في عطلات نهاية الأسبوع

            // 5. عامل الوقت من اليوم (مباريات المساء أكثر طلباً)
            bool isEveningMatch = matchDate.Hour >= 18 && matchDate.Hour < 22;
            if (isEveningMatch) demandMultiplier += 0.08m;              // +8% للمباريات المسائية

            // عوامل العرض (تخفيض السعر)
            decimal supplyMultiplier = 1.0m;

            // 1. عامل انخفاض الطلب (إذا كانت نسبة البيع منخفضة)
            if (soldPercentage < 20 && daysToMatch > 3)
                supplyMultiplier -= 0.15m;                              // -15% إذا كان البيع أقل من 20% وبقي أكثر من 3 أيام
            else if (soldPercentage < 30 && daysToMatch > 2)
                supplyMultiplier -= 0.10m;                              // -10% إذا كان البيع أقل من 30% وبقي أكثر من يومين
            else if (soldPercentage < 40 && daysToMatch > 1)
                supplyMultiplier -= 0.05m;                              // -5% إذا كان البيع أقل من 40% وبقي أكثر من يوم

            // 2. عامل التخفيض الأخير (آخر 24 ساعة إذا كان البيع ضعيفاً)
            if (hoursToMatch <= 24 && soldPercentage < 25)
                supplyMultiplier -= 0.20m;                              // -20% تخفيض أخير

            // 3. عامل المباريات غير المهمة
            if (!isBigMatch && soldPercentage < 35 && daysToMatch > 5)
                supplyMultiplier -= 0.08m;                              // -8% للمباريات غير المهمة مع بيع ضعيف

            // 4. عامل منتصف الأسبوع الصباحي
            bool isWeekdayMorning = !isWeekend && matchDate.Hour >= 10 && matchDate.Hour < 16;
            if (isWeekdayMorning && soldPercentage < 50)
                supplyMultiplier -= 0.07m;                              // -7% للمباريات الصباحية في منتصف الأسبوع

            // تطبيق المضاعفات
            price = price * demandMultiplier * supplyMultiplier;

            // عوامل خاصة بالمنافسة
            decimal competitionFactor = 1.0m;

            // 1. مباريات القمة (زيادة إضافية)
            if (isBigMatch && soldPercentage > 75)
                competitionFactor += 0.10m;                             // +10% إضافية لمباريات القمة مع طلب عالي

            // 2. العرض الخاص (آخر 10 تذاكر)
            int remainingTickets = totalTickets - soldTickets;
            if (remainingTickets <= 10 && remainingTickets > 0)
                competitionFactor += 0.05m;                             // +5% للعشر تذاكر الأخيرة

            price = price * competitionFactor;

            // الحدود القصوى (لا تزيد عن 50% ولا تقل عن 20% من السعر الأساسي)
            var maxPrice = basePrice * 1.50m;
            var minPrice = basePrice * 0.80m;

            price = Math.Max(minPrice, Math.Min(maxPrice, price));

            // تقريب إلى أقرب 0.95 أو 0.99 (تسعير نفسي)
            decimal roundedPrice = Math.Round(price, 1);
            decimal fractionalPart = roundedPrice - Math.Floor(roundedPrice);

            if (fractionalPart < 0.50m)
            {
                roundedPrice = Math.Floor(roundedPrice) + 0.95m;
            }
            else
            {
                roundedPrice = Math.Floor(roundedPrice) + 0.99m;
            }

            // التأكد من أن السعر النهائي ضمن الحدود
            roundedPrice = Math.Max(minPrice, Math.Min(maxPrice, roundedPrice));

            return Math.Round(roundedPrice, 2);
        }
    }
}
