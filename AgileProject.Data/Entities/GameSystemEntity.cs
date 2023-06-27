using System.ComponentModel.DataAnnotations;

namespace AgileProject.Data.Entities
{
    public class GameSystemEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Model { get; set; }
        public string SKU { get; set; }
        public decimal Price { get; set; }
        public List<GameEntity>GamesOnSystem { get; set; }
    }
}