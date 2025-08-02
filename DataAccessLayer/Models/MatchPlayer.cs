using CoreLayer.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    [PrimaryKey(nameof(MatchId), nameof(PlayerId), nameof(TeamId))]
    public class MatchPlayer : BaseModel
    {
        public int MatchId { get; set; }
        public Match Match { get; set; } = null!;
        public int PlayerId { get; set; }
        public Player Player { get; set; } = null!;
        public int TeamId { get; set; }
        public Team Team { get; set; } = null!;
        public bool IsSubsitute { get; set; } = false;
        public int MinuteIn { get; set; } = 0;
        public int MinuteOut { get; set; } = 0;
        public string? ExitReason { get; set; }
        public PlayerPosition? Position { get; set; }

    }
}
