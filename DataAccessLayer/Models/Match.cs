using CoreLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Match : BaseModel
    {
        public int Id { get; set; }
        public DateTime MatchDate { get; set; }
        public string? Location { get; set; }
        public int HomeTeamId { get; set; }
        [ForeignKey(nameof(HomeTeamId))]
        public Team HomeTeam { get; set; } = null!;
        public int AwayTeamId { get; set; }
        [ForeignKey(nameof(AwayTeamId))]
        public Team AwayTeam { get; set; } = null!;
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public MatchStatus Status { get; set; }
        public int TournamentId { get; set; }
        [ForeignKey(nameof(TournamentId))]
        public Tournament Tournament { get; set; } = null!;
        public ICollection<TicketPrice> TicketPrices { get; set; } = new List<TicketPrice>();
        [NotMapped]
        public int AvailableTickets => TicketPrices.Sum(tp => tp.AvailableTickets);
        public decimal TicketPrice { get; set; } = 0;
        public bool IsBookable { get; set; } = false;
        public bool isBigMatch { get; set; } = false;
        [NotMapped]
        public bool IsAvailableForBooking => DateOnly.FromDateTime(MatchDate) >= DateOnly.FromDateTime(DateTime.Now)
                                           && IsBookable == true && AvailableTickets > 0;
    }
}
