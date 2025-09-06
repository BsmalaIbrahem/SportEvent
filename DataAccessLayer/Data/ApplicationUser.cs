using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Address { get; set; }
        public int Points { get; set; } = 0;
        public string? NationalId { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public string? NationalIdFrontImage { get; set; }
        public string? NationalIdBackImage { get; set; }

    }
}
