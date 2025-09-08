using CoreLayer.Enums;
using DataAccessLayer.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.ViewModels
{
    public class AddCartVM
    {
        public int MatchId { get; set; }
        public int TeamId { get; set; }
        public List<AddCartItemVM> CartItems { get; set; }
    }

}
