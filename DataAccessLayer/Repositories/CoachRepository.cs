using DataAccessLayer.Data;
using DataAccessLayer.Models;
using SportEvent.Repositories;

namespace DataAccessLayer.Repositories
{
    public class CoachRepository : MainRepository<Coach> , ICoachRepository
    {
        public CoachRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
