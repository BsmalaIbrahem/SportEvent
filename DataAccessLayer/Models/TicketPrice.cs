using CoreLayer.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    [PrimaryKey(nameof(MatchId), nameof(Category))]
    public class TicketPrice : BaseModel
    {
        public int MatchId { get; set; }
        public Match Match { get; set; } = null!;
        public TicketCategory Category { get; set; } = TicketCategory.CAT2;
        public decimal Price { get; set; }
        public int HomeTickets { get; set; } = 0;
        public int AwayTickets { get; set; } = 0;
        [NotMapped]
        public int AvailableTickets => HomeTickets + AwayTickets;
    }
}
