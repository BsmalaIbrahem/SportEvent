using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    [PrimaryKey (nameof(TeamId), nameof(PlayerId))]
    public class TeamPlayer : BaseModel
    {
        public int TeamId { get; set; }
        public Team Team { get; set; } = null!;
        public int PlayerId { get; set; }
        public Player Player { get; set; } = null!;
        public DateTime JoinedDate { get; set; }
        public DateTime? LeftDate { get; set; } = null;
        public int ? Number { get; set; } = null;
        public bool IsCaptain { get; set; } = false;

    }
}
