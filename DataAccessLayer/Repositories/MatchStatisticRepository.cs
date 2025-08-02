using DataAccessLayer.Data;
using DataAccessLayer.Models;
using SportEvent.Repositories;


namespace DataAccessLayer.Repositories
{
    public class MatchStatisticRepository : MainRepository<MatchStatistic>, IMatchStatisticRepository
    {
        private readonly ApplicationDbContext _context;

        public MatchStatisticRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
