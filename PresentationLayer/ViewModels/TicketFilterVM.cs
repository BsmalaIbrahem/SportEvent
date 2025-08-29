using CoreLayer.Enums;

namespace PresentationLayer.ViewModels
{
    public class TicketFilterVM
    {
        public PageFilterVM PageFilter { get; set; } = new PageFilterVM();
        public TicketStatus? Status { get; set; }
    }
}
