using AgileProject.Models.GameModels;

namespace AgileProject.Services.GameServices
{
    public interface IGameService
    {
        Task<bool> UpdateGame(GameEdit model);
    }
}