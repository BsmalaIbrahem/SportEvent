namespace PresentationLayer.ViewModels
{
    public class PageFilterVM
    {
        public int? PageNumber { get; set; } = 1;
        public int? PageSize { get; set; } = 5;
        public int? SkipNumber => (PageNumber - 1) * PageSize;
        public string? SearchTerm { get; set; }
    }
}
