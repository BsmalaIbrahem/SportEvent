using CoreLayer.Enums;

namespace PresentationLayer.ViewModels
{
    public class EditPointSystemVM
    {
        public PointActionType ActionType { get; set; }
        public int FixedPoints { get; set; } = 0;
        public int PointsPerUnit { get; set; } = 0;
        public int UnitValue { get; set; } = 0;
    }
}
