using DataAccessLayer.Data;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ApplicationUserOTPRepository : MainRepository<ApplicationUserOTP>, IApplicationUserOTPRepository
    {

        public ApplicationUserOTPRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
