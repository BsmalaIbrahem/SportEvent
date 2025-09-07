using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.ViewModels
{
    public class ChangePasswordVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Old PassWord is Requierd")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; } = null!;

        [Required(ErrorMessage ="New Password is Required")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; } = null!;
        [Required(ErrorMessage ="Pleas Confirm New Password")]
        [DataType(DataType.Password)]
        [Compare("NewPassword",ErrorMessage ="Password Not Match")]
        public string ConfirmPassword { get; set; } = null!;
    }
}
