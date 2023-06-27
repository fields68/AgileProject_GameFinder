using AgileProject.Models.GenreModels;

namespace AgileProject.Services.GenreServices
{
    public interface IGenreService
    {
        public Task<GenreDetail> GetDetail();
        public Task<List<GenreListItem>> GetGenreLists();
    }
}

// Ticket 8: Make a “Read” method for GameGenre List