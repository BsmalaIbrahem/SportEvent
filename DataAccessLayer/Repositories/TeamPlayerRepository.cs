using DataAccessLayer.Data;
using DataAccessLayer.Models;
using SportEvent.Repositories;


namespace DataAccessLayer.Repositories
{
    public class TeamPlayerRepository : MainRepository<TeamPlayer>, ITeamPlayerRepository
    {
        private readonly ApplicationDbContext _context;

        public TeamPlayerRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
