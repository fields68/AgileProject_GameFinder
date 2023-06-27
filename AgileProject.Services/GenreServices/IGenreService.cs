using AgileProject.Models.GenreModels;

namespace AgileProject.Services.GenreServices
{
    public class IGenreService
    {
        public Task<GenreDetail> GetDetail;
        // public Task<List<GenreListItem>> GetGenreLists();
    }
}