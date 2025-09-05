using DataAccessLayer.Data;
using DataAccessLayer.Repositories.IRepositories;
using SportEvent.Repositories;

namespace DataAccessLayer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ICoachRepository coachRepository,
            IContactRepository contactRepository,IMatchPlayerRepository matchPlayerRepository,
            IMatchRepository matchRepository,IMatchStatisticRepository matchStatisticRepository,
            INewRepository newRepository,IPlayerRepository playerRepository,ITeamRepository teamRepository
            ,ITeamPlayerRepository teamPlayerRepository,ITournamentRepository tournamentRepository, ITicketRepository ticketRepository,
            ICartRepository cartRepository, ICartItemRepository cartItemRepository,
            ApplicationDbContext context)
        {
            CoachRepository = coachRepository;
            ContactRepository = contactRepository;
            MatchPlayerRepository = matchPlayerRepository;
            MatchRepository = matchRepository;
            MatchStatisticRepository = matchStatisticRepository;
            NewRepository = newRepository;
            PlayerRepository = playerRepository;
            TeamRepository = teamRepository;
            TeamPlayerRepository = teamPlayerRepository;
            TournamentRepository = tournamentRepository;
            TicketRepository = ticketRepository;
            CartRepository = cartRepository;
            CartItemRepository = cartItemRepository;
            _context = context;
        }
        public ICoachRepository CoachRepository { get; }
        public IContactRepository ContactRepository { get; }
        public IMatchPlayerRepository MatchPlayerRepository { get; }
        public IMatchRepository MatchRepository { get; }
        public IMatchStatisticRepository MatchStatisticRepository { get; }
        public INewRepository NewRepository { get; }
        public IPlayerRepository PlayerRepository { get; }
        public ITeamRepository TeamRepository { get; }
        public ITeamPlayerRepository TeamPlayerRepository { get; }
        public ITournamentRepository TournamentRepository { get; }

        public IApplicationUserOTPRepository ApplicationUserOTPRepository { get; }

        public ITicketRepository TicketRepository {get; }
        public ICartRepository CartRepository { get; }
        public ICartItemRepository CartItemRepository { get; }

        void IDisposable.Dispose()
        {
        }
    }
}
