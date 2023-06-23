using System.ComponentModel.DataAnnotations;
using AgileProject.Data.Entities;

namespace AgileProject.Models.GameSystemModels
{
    public class GameSystemCreate
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [Required]
        [MaxLength(150)]
        public string Modele { get; set; }
        [Required]
        [MaxLength(100)]
        public string SKU { get; set; }
        [Required]
        [MaxLength(50)]
        public double Price { get; set; }
        public object Model { get; set; }

        //public List<GameEntity> GamesOnSystem { get; set; }
    }
}