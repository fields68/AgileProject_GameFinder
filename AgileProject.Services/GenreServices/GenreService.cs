using AgileProject.Data.AgileProjectContext;
using AgileProject.Models.GenreModels;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

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

        public Task<GenreDetail> GetDetail(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GenreListItem>> GetGenreLists()
        {
            var genre = await _context.Genre.ToListAsync();
            return _mapper.Map<List<GenreListItem>>(genre);
        }
    }
}