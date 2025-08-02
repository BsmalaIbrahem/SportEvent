using DataAccessLayer.Data;
using DataAccessLayer.Models;
using SportEvent.Repositories;


namespace DataAccessLayer.Repositories
{
    public class BaseModelRepository : MainRepository<BaseModel>, IBaseModelRepository
    {
        private readonly ApplicationDbContext _context;

        public BaseModelRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
