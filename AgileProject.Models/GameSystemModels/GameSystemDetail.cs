using System.ComponentModel.DataAnnotations;

namespace AgileProject.Models.GameSystemModels
{
    public class GameSystemDetail
    {

        public int Id { get; set; }

        public string Name { get; set; }
        public string Model { get; set; }
        public string SKU { get; set; }
        public double Price { get; set; }
        public GameSystemListItem GameSystem { get; set; } = new GameSystemListItem();
    }
}