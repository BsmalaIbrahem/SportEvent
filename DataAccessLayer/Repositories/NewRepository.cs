using DataAccessLayer.Data;
using DataAccessLayer.Models;
using SportEvent.Repositories;


namespace DataAccessLayer.Repositories
{
    public class NewRepository : MainRepository<New>, INewRepository
    {
        private readonly ApplicationDbContext _context;

        public NewRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
