using System.ComponentModel.DataAnnotations;

namespace AgileProject.Models.GameModels
{
    public class GameCreate
    {
        [Required]
        [MaxLength(100, ErrorMessage = "Title cannot exceed 100 characters!")]
        public string Title { get; set; } = null!;

        [Required]
        public int GenreId { get; set; }

        [Required]
        public int GameSystemId { get; set; }
    }
}