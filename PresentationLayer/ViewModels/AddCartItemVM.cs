using CoreLayer.Enums;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.ViewModels
{
    public class AddCartItemVM
    {
        public string TicketCategory { get; set; }
        public int Quantity { get; set; }
    }
}
