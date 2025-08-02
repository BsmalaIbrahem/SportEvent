using DataAccessLayer.Data;
using DataAccessLayer.Repositories.IRepositories;
using SportEvent.Repositories;

namespace DataAccessLayer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(IBaseModelRepository baseModelRepository,ICoachRepository coachRepository,
            IContactRepository contactRepository,IMatchPlayerRepository matchPlayerRepository,
            IMatchRepository matchRepository,IMatchStatisticRepository matchStatisticRepository,
            INewRepository newRepository,IPlayerRepository playerRepository,ITeamRepository teamRepository
            ,ITeamPlayerRepository teamPlayerRepository,ITournamentRepository tournamentRepository,
            ApplicationDbContext context)
        {
            BaseModelRepository = baseModelRepository;
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
            _context = context;
        }

        public IBaseModelRepository BaseModelRepository { get; }
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

       
        void IDisposable.Dispose()
        {
        }
    }
}
