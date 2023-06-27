using System.ComponentModel.DataAnnotations;

namespace AgileProject.Models.GameSystemModels
{
    public class GameSystemEdit
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [Required]
        [MaxLength(150)]
        public string Model { get; set; }
        [Required]
        [MaxLength(100)]
        public string SKU { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}