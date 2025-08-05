using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System;

namespace PresentationLayer.ViewModels
{
    public class CreateTeamVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        [Required(ErrorMessage = "Logo URL is required.")]
        public string? LogoUrl { get; set; } = string.Empty;
        [Required(ErrorMessage = "Country is required.")]
        public string Country { get; set; } = string.Empty;
        [Required(ErrorMessage = "Founded date is required.")]
        public DateTime Founded { get; set; }
        [Required(ErrorMessage = "Coach is required.")]
        public int CoachesId { get; set; }
        public List<SelectListItem> Coaches { get; set; } = new List<SelectListItem>();
        [Required(ErrorMessage = "At least one player is required.")]
        public List<PlayerSelection> SelectedPlayers { get; set; } = new List<PlayerSelection>();
        public List<SelectListItem> AvailablePlayers { get; set; } = new List<SelectListItem>();
        [Required(ErrorMessage = "Captain is required.")]
        public int CaptainId { get; set; }

        public class PlayerSelection
        {
            public int PlayerId { get; set; }
            [Required(ErrorMessage = "Joined date is required for each player.")]
            public DateTime JoinedDate { get; set; }
            [Range(1, 99, ErrorMessage = "Player number must be between 1 and 99.")]
            public int? Number { get; set; }
        }
    }
}