using DataAccessLayer.Data;
using DataAccessLayer.Models;
using SportEvent.Repositories;


namespace DataAccessLayer.Repositories
{
    public class TeamRepository : MainRepository<Team>, ITeamRepository

    {
        private readonly ApplicationDbContext _context;

        public TeamRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
