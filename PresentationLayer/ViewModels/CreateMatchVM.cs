using CoreLayer.Enums;
using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.ViewModels
{
    public class CreateMatchVM
    {
        [Required(ErrorMessage = "Home Team is required.")]
        public int HomeTeamId { get; set; }
        [Required(ErrorMessage = "Away Team is required.")]
        public int AwayTeamId { get; set; }
        [Required(ErrorMessage = "Tournament is required.")]
        public int TournamentId { get; set; }
        [Required(ErrorMessage = "Match Date is required.")]
        [DataType(DataType.DateTime)]
        public DateTime MatchDate { get; set; }
        public string? Location { get; set; }
        [Required]
        public MatchStatus MatchStatus { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Available Tickets must be a non-negative number.")]
        public int HomeScore { get; set; } = 0;
        [Range(0, int.MaxValue, ErrorMessage = "Available Tickets must be a non-negative number.")]
        public int AwayScore { get; set; } = 0;
        [Range(0, int.MaxValue, ErrorMessage = "Available Tickets must be a non-negative number.")]
        public int AvailableTickets { get; set; } = 0;
    }
}
