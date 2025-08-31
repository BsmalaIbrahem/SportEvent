
using CoreLayer.Enums;
using DataAccessLayer.Repositories.IRepositories;

namespace PresentationLayer.HostedServices
{
    public class MatchStatusService : BackgroundService
    {
        private readonly ILogger<MatchStatusService> _logger;
        private readonly IServiceScopeFactory _scopeFactory;

        public MatchStatusService(ILogger<MatchStatusService> logger, IServiceScopeFactory scopeFactory)
        {
            _logger = logger;
            _scopeFactory = scopeFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await DoWork();

                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
        }

        private async Task DoWork()
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                var unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();

                var InprogressMatches = await unitOfWork.MatchRepository.GetAllAsync(m =>
                    m.Status == MatchStatus.Scheduled &&
                    m.MatchDate <= DateTime.Now &&
                    m.MatchDate > DateTime.Now.AddHours(-3)
                );

                foreach (var match in InprogressMatches)
                {
                    match.Status = MatchStatus.InProgress;
                    unitOfWork.MatchRepository.Update(match);
                }
                await unitOfWork.MatchRepository.SaveChangesAsync();

            }
        }
    }

}
