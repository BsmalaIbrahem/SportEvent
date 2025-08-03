using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Coach : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [Column(TypeName = "text")]
        public string? Description { get; set; } = string.Empty;
        public string? ImageUrl { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
    }
}
