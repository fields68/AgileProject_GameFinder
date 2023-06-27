using AgileProject.Data.AgileProjectContext;
using AutoMapper;

namespace AgileProject.Services.GenreServices
{
    public class GenreService : IGenreService
    {
        private readonly AgileProjectDBContext _context;
        private readonly IMapper _mapper;

        public GenreService(AgileProjectDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // public Task<GenreDetail> GetDetail;

        // public Task<List<GenreListItem>> GetGenreLists();
        
    }
}