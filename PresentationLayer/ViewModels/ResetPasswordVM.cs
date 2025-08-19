using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.ViewModels
{
    public class ResetPasswordVM
    {
        public string UserId { get; set; } = string.Empty;
        [Required]
        public int OTP { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
