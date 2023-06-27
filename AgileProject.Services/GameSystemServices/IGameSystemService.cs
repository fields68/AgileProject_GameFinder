using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileProject.Data.AgileProjectContext;
using AgileProject.Models.GameSystemModels;
using AutoMapper;

namespace AgileProject.Services.GameSystemServices
{
    public interface IGameSystemService
    {
        public Task<bool> AddGameSystem(GameSystemCreate model);
        public Task<bool> UpdateGameSystem(GameSystemEdit model);
        public Task<bool> DeleteGameSystem(int id);
        public Task<List<GameSystemListItem>> GetGameSystems();
        public Task<GameSystemDetail> GetGameSystem(int id);
        public Task<List<GameSystemListItem>> GetGameSystem(string name);

        
    }
}