using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Team : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public string? LogoUrl { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public DateTime Founded { get; set; }
        public int CoachId { get; set; }
        [ForeignKey(nameof(CoachId))]
        public Coach Coach { get; set; } = null!;
        public ICollection<TeamPlayer> Players { get; set; } = new List<TeamPlayer>();
    }
}
