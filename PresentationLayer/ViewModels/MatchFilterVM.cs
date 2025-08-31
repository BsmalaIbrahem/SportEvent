using CoreLayer.Enums;

namespace PresentationLayer.ViewModels
{
    public class MatchFilterVM
    {
        public int? PageNumber { get; set; } = 1;
        public int? PageSize { get; set; } = 5;
        public int? SkipNumber => (PageNumber - 1) * PageSize;
        public string? SearchTerm { get; set; }
        public MatchStatus? status { get; set; }
        public bool? IsLive { get; set; }
        public bool ? IsToday { get; set; }
    }
}
