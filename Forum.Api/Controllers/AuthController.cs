using Forum.Contracts;
using Forum.Models.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace Forum.Api.Controllers
{

    [Route("api/auth")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register([FromForm] RegistrationRequestDto model)
        {
            try
            {
                await _authService.Register(model);
                return Ok(model);

            }
            catch (Exception ex) 
            {
               return BadRequest(ex.Message);
            }
        }

        /*

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromForm] LoginRequestDto model)
        {
            try
            {
                var loginResponse = await _authService.Login(model);    
                
                if(loginResponse == null)
                {
                    return BadRequest();
                }
                return Ok(loginResponse);

                

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        */

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto model)
        {
            try
            {
                var loginResponse = await _authService.Login(model);

                if (loginResponse == null)
                {
                    return BadRequest("Invalid login attempt.");
                }

                return Ok(loginResponse);
            }
            catch (Exception ex)
            {
                if (ex.Message == "Account is banned.")
                {
                    return Unauthorized("This account has been banned.");
                }

                return BadRequest(ex.Message);
            }
        }






        [HttpPost("registeradmin")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RegisterAdmin([FromForm] RegistrationRequestDto model)
        {
            try
            {
                await _authService.RegisterAdmin(model);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("banuser")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> BanUser(string userId)
        {
            try
            {
                await _authService.BanUser(userId);
                return Ok($"User {userId} banned successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost("removeban")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RemoveBan([FromForm] string email)
        {
            try
            {
                await _authService.RemoveBan(email);
                return Ok("Ban removed successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
