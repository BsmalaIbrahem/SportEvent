using CoreLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class PointSystem : BaseModel
    {
        public int Id { get; set; }
        public PointActionType ActionType { get; set; }
        public int FixedPoints { get; set; } = 0;
        public int PointsPerUnit { get; set; }= 0;
        public int UnitValue { get; set; } = 0;

    }
}
