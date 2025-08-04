using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.ViewModels
{
    public class EditCoachVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        [Required(ErrorMessage = "Nationality is Required")]
        public string Nationality { get; set; } = string.Empty;
        public string? ImgPath { get; set; }
    }
}
