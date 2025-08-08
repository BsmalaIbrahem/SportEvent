using CoreLayer.Enums;
using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.ViewModels
{
    public class CreatePlayerVM
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Nationality is Required")]
        public string Nationality { get; set; } = string.Empty;
        public string ImgPath { get; set; } = string.Empty;
        [Required(ErrorMessage = "Date of Birth is required.")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Position is required.")]
        public PlayerPosition? Position { get; set; }
        [Required(ErrorMessage = "Team is required.")]
        public int TeamId { get; set; }
        public int? Number { get; set; }
        public bool IsCaptain { get; set; } = false;
        [Required(ErrorMessage = "Joined Date is required.")]
        public DateTime JoinedDate { get; set; }

    }
}
