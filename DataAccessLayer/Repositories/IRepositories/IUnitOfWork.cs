using Microsoft.EntityFrameworkCore.Storage;
using SportEvent.Repositories;

namespace DataAccessLayer.Repositories.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        ICoachRepository CoachRepository { get; }
        IContactRepository ContactRepository { get; }
        IMatchPlayerRepository MatchPlayerRepository { get; }
        IMatchRepository MatchRepository { get; }
        IMatchStatisticRepository MatchStatisticRepository { get; }
        INewRepository NewRepository { get; }
        IPlayerRepository PlayerRepository { get; }
        ITeamRepository TeamRepository { get; }
        ITeamPlayerRepository TeamPlayerRepository { get; }
        ITournamentRepository TournamentRepository { get; }
        IApplicationUserOTPRepository ApplicationUserOTPRepository { get; }
        ITicketRepository TicketRepository { get; }
        ICartRepository CartRepository { get; }
        ICartItemRepository CartItemRepository { get; }
        ITicketPriceRepository TicketPriceRepository { get; }
        ITicketMatchRepository TicketMatchRepository { get; }
        Task SaveChangesAsync();
        Task<IDbContextTransaction> BeginTransactionAsync();
    }
}
