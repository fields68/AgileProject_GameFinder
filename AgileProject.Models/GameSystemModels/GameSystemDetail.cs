using System.ComponentModel.DataAnnotations;
using AgileProject.Models.GameModels;

namespace AgileProject.Models.GameSystemModels
{
    public class GameSystemDetail
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string SKU { get; set; }
        public double Price { get; set; }
         public List<GameListItem>GamesOnSystem { get; set; }
    }
}