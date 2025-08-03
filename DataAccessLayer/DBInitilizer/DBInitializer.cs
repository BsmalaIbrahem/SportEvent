using CoreLayer.Utility;
using DataAccessLayer.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DBInitilizer
{
    public class DBInitializer : IDBInitializer
    {
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public DBInitializer(ApplicationDbContext context, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public void Initialize()
        {
            if (_context.Database.GetPendingMigrations().Any())
            {
                _context.Database.Migrate();
            }

            if (_roleManager.Roles.IsNullOrEmpty())
            {
                _roleManager.CreateAsync(new(SD.SuperAdmin)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new(SD.Admin)).GetAwaiter().GetResult(); ;
                _roleManager.CreateAsync(new(SD.Employee)).GetAwaiter().GetResult(); ;
                _roleManager.CreateAsync(new(SD.Customer)).GetAwaiter().GetResult(); ;

                _userManager.CreateAsync(new()
                {
                    FirstName = "Super",
                    LastName = "Admin",
                    UserName = "SuperAdmin",
                    Email = "SuperAdmin@sportEvent.com",
                    EmailConfirmed = true,
                }, "Admin123&").GetAwaiter().GetResult(); ;

                var user = _userManager.FindByNameAsync("SuperAdmin").GetAwaiter().GetResult();

                _userManager.AddToRoleAsync(user, SD.SuperAdmin).GetAwaiter().GetResult();
            }
        }
    }
}
