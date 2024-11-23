using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using QuitQ.Repositories.Interfaces;
using QuitQ.Services;

namespace QuitQ.Controllers
{
    /*
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtAuthenticationService _jwtAuthenticationService;
        private readonly ILogger<AuthController> _logger;

        public AuthController(IUserRepository userRepository, IJwtAuthenticationService jwtAuthenticationService, ILogger<AuthController> logger)
        {
            _userRepository = userRepository;
            _jwtAuthenticationService = jwtAuthenticationService;
            _logger = logger;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            var user = await _userRepository.GetUserByEmailAsync(loginRequest.Email);

            if (user == null || !await _userRepository.ValidatePasswordAsync(loginRequest.Email, loginRequest.Password))
            {
                return Unauthorized("Invalid email or password.");
            }

            // Role-based authorization: e.g., Check if the user is an Admin
            if (!await _userRepository.IsUserAuthorizedAsync(loginRequest.Email, "Admin") &&
                !await _userRepository.IsUserAuthorizedAsync(loginRequest.Email, "Seller") &&
                !await _userRepository.IsUserAuthorizedAsync(loginRequest.Email, "Customer"))
            {
                return Unauthorized("User is not authorized.");
            }

            // Generate JWT token
            var token = await _jwtAuthenticationService.GenerateJwtTokenAsync(user);

            _logger.LogInformation($"User {loginRequest.Email} logged in successfully.");

            return Ok(new { Token = token });
        }
    }
    */
}
