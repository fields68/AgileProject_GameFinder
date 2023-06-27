using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileProject.Data.AgileProjectContext;
using AgileProject.Data.Entities;
using AgileProject.Models.GameSystemModels;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AgileProject.Services.GameSystemServices
{
    public class GameSystemService : IGameSystemService
    {
        private readonly AgileProjectDBContext _context;
        
        private readonly IMapper _mapper;
        public GameSystemService(AgileProjectDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> AddGameSystem(GameSystemCreate model)
        {
             var gameSystem = new GameSystemEntity
            {
                
                Name = model.Name,
                Model = model.Model,
                SKU = model.SKU,
                Price = model.Price
            };

            await _context.GameSystems.AddAsync(gameSystem);
            return await _context.SaveChangesAsync() > 0;
        }

         public async Task<bool> UpdateGameSystem(GameSystemEdit model)
        {
            var gameSystem = await _context.GameSystems.SingleOrDefaultAsync(x => x.Id == model.Id);

            if (gameSystem is not null)
            {
                gameSystem.Name = model.Name;
                gameSystem.Model = model.Model;
                gameSystem.SKU = model.SKU;
                gameSystem.Price = model.Price;

                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public async Task<bool> DeleteGameSystem(int id)
        {
            var gameSystem = await _context.GameSystems.FindAsync(id);
            if(gameSystem is null)
            return false;
            _context.GameSystems.Remove(gameSystem);
            return await _context.SaveChangesAsync() >0;
        }

        public async Task<List<GameSystemListItem>> GetGameSystems()
        {
            var gameSystems = await _context.GameSystems.ToListAsync();
            var gameSystemListItems1 = _mapper.Map<List<GameSystemListItem>>(gameSystems);
            return gameSystemListItems1;
        }

        public async Task<GameSystemDetail> GetGameSystem(int id)
        {
             var gameSystem = await _context.GameSystems.Include(g => g.GamesOnSystem).FirstOrDefaultAsync(x => x.Id == id);

            if (gameSystem is null)
                return new GameSystemDetail ();

            return _mapper.Map<GameSystemDetail>(gameSystem);
           
        }

        public async Task<List<GameSystemListItem>> GetGameSystem(string name)

        {
            var gameSystems = await _context.GameSystems.Where(x=>x.Name.ToLower().Contains(name)).ToListAsync();
            if(gameSystems is null)
               return null!;
            else
            return _mapper.Map<List<GameSystemListItem>>(gameSystems);   
        }
    }
}