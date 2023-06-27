namespace AgileProject.Data.Entities
{
    public class GenreEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<GameEntity>? Games { get; set; }
    }
}