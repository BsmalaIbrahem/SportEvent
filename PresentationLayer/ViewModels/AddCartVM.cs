using CoreLayer.Enums;
using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.ViewModels
{
    public class AddCartVM
    {
        [Required]
        public int MatchId { get; set; }
        [Required]
        public int TeamId { get; set; }
        [Required]
        public ICollection<AddCartItemVM> CartItems { get; set; } = null!;
    }
}
