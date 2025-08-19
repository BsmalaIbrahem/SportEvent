using CoreLayer.Enums;
using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.ViewModels
{
    public class CreateTournamentVM
    {
        [Required(ErrorMessage = "Tournament name is required.")]
        public TournamentTitles Title { get; set; }
        [MaxLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "Season is required.")]
        [MaxLength(255, ErrorMessage = "Season cannot exceed 255 characters.")]
        public string Season { get; set; } = string.Empty;
        [Required(ErrorMessage = "Start date is required.")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "End date is required.")]
        public DateTime EndDate { get; set; }
        public string? Venue { get; set; }
        [Required(ErrorMessage = "Tournament type is required.")]
        public TournamentType Type { get; set; }
    }
}
