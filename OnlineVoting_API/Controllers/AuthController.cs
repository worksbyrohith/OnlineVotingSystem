using Microsoft.AspNetCore.Mvc;
using OnlineVoting_API.DTOs.Auth;
using OnlineVoting_API.Services;
using static OnlineVoting_API.DTOs.Auth.AuthDto;

namespace OnlineVoting_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            var result = await _authService.Register(dto);
            return Ok(result);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            var result = await _authService.Login(dto);
            return Ok(result);
        }
    }
}