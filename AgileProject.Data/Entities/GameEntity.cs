using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgileProject.Data.Entities
{
    public class GameEntity
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string Title { get; set; } = null!;

        public int GameSystemId { get; set; }
        [ForeignKey(nameof(GameSystemId))]
        public virtual GameSystemEntity GameSystem { get; set; }

        public int GenreId { get; set; }
        [ForeignKey(nameof(GenreId))]
        public virtual GenreEntity Genre { get; set; }

        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual UserEntity User { get; set; }

    }
}