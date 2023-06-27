using AgileProject.Models.GameModels;

namespace AgileProject.Services.GameServices
{
    public interface IGameService
    {
        Task<bool> AddGame(GameCreate model);
        Task<bool> DeleteGame(int id);
        Task<bool> UpdateGame(GameEdit model);
    }
}
