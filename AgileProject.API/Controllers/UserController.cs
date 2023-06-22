using AgileProject.Models.UserModels;
using AgileProject.Services.UserServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AgileProject.API.Controllers
{
   [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IAuthenticationManager _authManager;

        public UserController(IAuthenticationManager authManager)
        {
            _authManager = authManager;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody]UserEntityVM userEntityVM)
        {
            var errors = await _authManager.Register(userEntityVM);
            if (errors.Any())
            {
                foreach (IdentityError error in errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
            }
            return Ok("User is Registered");
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody]Login login)
        {
            var authResponse = await _authManager.Login(login);
            if (authResponse is null)
            {
                return Unauthorized();
            }
            return Ok(authResponse);
        }
    }
}