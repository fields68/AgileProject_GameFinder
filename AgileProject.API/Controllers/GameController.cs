using AgileProject.Models.GameModels;
using AgileProject.Services.GameServices;
using Microsoft.AspNetCore.Mvc;

namespace AgileProject.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public async Task<IActionResult> Delete(int id)
        {
            if (await _gameService.DeleteGame(id))
                return Ok("Like deleted!");
            else
                return StatusCode(500, "Internal Server Error");
        }

        public async Task<IActionResult> Put(GameEdit model, int id)
        {
            if (id != model.Id)
                return BadRequest("Invalid Id.");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            if (await _gameService.UpdateGame(model))
                return Ok("Game Updated.");
            else
                return StatusCode(500, "Internal Server Error");
        }
    }
}