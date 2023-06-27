using AgileProject.Data.AgileProjectContext;
using AgileProject.Data.Entities;
using AgileProject.Models.GameModels;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AgileProject.Services.GameServices
{
    public class GameService : IGameService
    {
        private readonly AgileProjectDBContext _context;
        private readonly IMapper _mapper;

        public GameService(AgileProjectDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> AddGame(GameCreate model)
        {
            var entity = _mapper.Map<GameEntity>(model);
            {
                await _context.Games.AddAsync(entity);
                return await _context.SaveChangesAsync() > 0;
            }
        }

        public async Task<bool> DeleteGame(int id)
        {
            var game = await _context.Games.FirstOrDefaultAsync(g => g.Id == id);
            if (game is null)
                return false;
            _context.Games.Remove(game);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateGame(GameEdit model)
        {
            var game = await _context.Games.Include(game => game.Title).SingleOrDefaultAsync(g => g.Id == model.Id);
            if (game is null)
                return false;

            game.Id = model.Id;
            game.GameSystemId = model.GameSystemId;
            // game.GenreId = model.GenreId;

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
