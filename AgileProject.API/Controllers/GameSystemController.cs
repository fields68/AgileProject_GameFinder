// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;

// namespace AgileProject.API.Controllers
// {
//     [ApiController]
//     [Route("api/[controller]")]
//     public class GameSystemController : ControllerBase
//     {
//          private readonly IGameSystemService _gameSystemService;

//         public GameSystemController(IGameSystemService gameSystemService)
//         {
//             _gameSystemService = gameSystemService;
//         }

//         [HttpGet]
//         public async Task<IActionResult> Get()
//         {
//             return Ok(await _gameSystemService.GetGameSystems());
//         }
//         [HttpGet("{id:int}")]
//         public async Task<IActionResult> Get(int id)
//         {
//             var car = await _gameSystemService.GetCarById(id);
//             if (car is null)
//                 return NotFound();
//             else
//                 return Ok(gameSystem);
//         }

//          [HttpPost]
//         public async Task<IActionResult> Post(GameSystemCreate model)
//         {
//             if (!ModelState.IsValid)
//             {
//                 return BadRequest(ModelState);
//             }
//             if (await _gameSystemService.AddCar(model))
//                 return Ok("GameSystem Created!");
//             else
//                 return StatusCode(500, "Internal Server Error.");
//         }

//          [HttpPut("{id:int}")]  
//         public async Task<IActionResult> Put(GameServiceEdit model, int id)
//         {
//             if (id != model.Id)
//             {
//                 return BadRequest("Invalid Id.");
//             }

//             if (!ModelState.IsValid)
//             {
//                 return BadRequest(ModelState);
//             }

//             if (await _gameSystemService.UpdateGameSystem(model))
//                 return Ok("GameSystem Updated!");
//             else
//                 return StatusCode(500, "Internal Server Error.");
//         }

//         [HttpDelete("{id:int}")]
//         public async Task<IActionResult> Delete(string id)
//         {
//             if (await _gameSystemService.DeleteGameSystem(id))
//                 return Ok("GameSystem Deleted!");
//             else
//                 return StatusCode(500, "Internal Server Error.");
//         }

//     }
// }