using DataAccessLayer.Data;
using DataAccessLayer.Models;
using SportEvent.Repositories;


namespace DataAccessLayer.Repositories
{
    public class MatchPlayerRepository : MainRepository<MatchPlayer>, IMatchPlayerRepository
    {
        private readonly ApplicationDbContext _context;

        public MatchPlayerRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
