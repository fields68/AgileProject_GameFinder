using System.ComponentModel.DataAnnotations;
using AgileProject.Data.Entities;

namespace AgileProject.Models.GameSystemModels
{
    public class GameSystemCreate
    {
        
        
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
       

        //public List<GameEntity> GamesOnSystem { get; set; }
    }
}