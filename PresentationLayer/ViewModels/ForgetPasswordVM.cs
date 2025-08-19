using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.ViewModels
{
    public class ForgetPasswordVM
    {
        [Required]
        public string EmailOrUserName { get; set; } = string.Empty;
    }
}
