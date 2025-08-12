using DataAccessLayer.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PresentationLayer.ViewModels
{
    public class CreateNewsVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string AuthorId { get; set; } = string.Empty;
        [ForeignKey(nameof(AuthorId))]
        public ApplicationUser Author { get; set; } = null!;
        public string? ImgPath { get; set; } = null;
    }
}
