using CoreLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Player : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public PlayerPosition? Position { get; set; }
        public string? ImgPath { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; } = string.Empty;
        public ICollection<TeamPlayer> Teams { get; set; } = new List<TeamPlayer>();

    }
}
