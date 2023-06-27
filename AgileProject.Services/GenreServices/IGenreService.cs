using AgileProject.Models.GenreModels;

namespace AgileProject.Services.GenreServices
{
    public interface IGenreService
    {
        public Task<GenreDetail> GetDetail(int id);
        public Task<List<GenreListItem>> GetGenreLists();
    }
}

// Ticket 8: Make a “Read” method for GameGenre List