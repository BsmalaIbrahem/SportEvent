using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PresentationLayer.ViewModels
{
    public class UserProfileVM
    {
        [Required]
        public string FirstName { get; set; } = null!;
        [Required]
        public string LastName { get; set; } = null!;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public int Points { get; set; } = 0;
        public string? ProfilePictureUrl { get; set; }
        public IFormFile? ProfilePicture { get; set; } 


        // Check If Current Password Is Valid
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; } = null!;


    }
}
