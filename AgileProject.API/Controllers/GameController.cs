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

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(GameCreate model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            if (await _gameService.AddGame(model))
                return Ok("Success! Game Created!");
            else
                return StatusCode(500, "Internal Server Error");

        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            if (await _gameService.DeleteGame(id))
                return Ok("Like deleted!");
            else
                return StatusCode(500, "Internal Server Error");
        }

        [HttpPut("{id:int}")]
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
