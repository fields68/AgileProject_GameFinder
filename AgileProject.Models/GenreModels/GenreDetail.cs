using AgileProject.Data.Entities;

namespace AgileProject.Models.GenreModels
{
    public class GenreDetail
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<GenreListItem>? Games { get; set; }
    }
}