using DataAccessLayer.Data;
using DataAccessLayer.Models;
using SportEvent.Repositories;


namespace DataAccessLayer.Repositories
{
    public class ContactRepository : MainRepository<Contact>, IContactRepository
    {
        private readonly ApplicationDbContext _context;

        public ContactRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
