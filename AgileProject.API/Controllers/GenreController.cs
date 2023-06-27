using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileProject.Services.GenreServices;
using Microsoft.AspNetCore.Mvc;

namespace AgileProject.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService _genreService

        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        [HttpGet]
        public async Task<IActionResult> GetGenreList()
        {
            return Ok(await _genreService.GetGenreLists());
        }
    }
}