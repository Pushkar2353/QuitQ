using log4net.Repository.Hierarchy;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using QuitQ.Controllers;
using QuitQ.Models;
using QuitQ.Repositories.Interfaces;
using Serilog.Core;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace QuitQ.Services
{
    /*
    public class AuthService : IJwtAuthenticationService
    {
        private readonly IConfiguration _configuration;
        private readonly IUserRepository _userRepository;
        private readonly ILogger<AuthService> _logger;

        // Constructor where we inject the logger
        public AuthService(IConfiguration configuration, IUserRepository userRepository, ILogger<AuthService> logger)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        // Generate JWT token
        public async Task<string> GenerateJwtTokenAsync(User user)
        {
            if (user == null)
            {
                _logger.LogError("User object is null.");
                throw new ArgumentNullException(nameof(user), "User cannot be null");
            }

            _logger.LogInformation($"Generating JWT for user: {user.Email}, UserType: {user.UserType}");

            if (string.IsNullOrEmpty(user.Email))
            {
                _logger.LogError("User email is null or empty.");
                throw new ArgumentNullException(nameof(user.Email), "User email cannot be null or empty.");
            }

            if (string.IsNullOrEmpty(user.UserType))
            {
                _logger.LogError("User type is null or empty.");
                throw new ArgumentNullException(nameof(user.UserType), "User type cannot be null or empty.");
            }

            var claims = new[]
            {
            new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
            new Claim(ClaimTypes.Name, user.Email),
            new Claim(ClaimTypes.Role, user.UserType)
        };

            // Get the SecretKey from configuration and validate it
            var secretKey = _configuration["Jwt:SecretKey"];
            if (string.IsNullOrEmpty(secretKey))
            {
                _logger.LogError("JWT SecretKey is not configured.");
                throw new InvalidOperationException("JWT SecretKey is not configured.");
            }

            // Convert the SecretKey to bytes only if it's not null or empty
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds
            );

            _logger.LogInformation("JWT token generated successfully.");
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        // Validate JWT token
        public async Task<bool> ValidateJwtTokenAsync(string token)
        {
            var secretKey = _configuration["Jwt:SecretKey"];
            if (string.IsNullOrEmpty(secretKey))
            {
                _logger.LogError("JWT SecretKey is not configured.");
                throw new InvalidOperationException("JWT SecretKey is not configured.");
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var handler = new JwtSecurityTokenHandler();

            try
            {
                var principal = handler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidIssuer = _configuration["Jwt:Issuer"],
                    ValidAudience = _configuration["Jwt:Audience"],
                    IssuerSigningKey = key
                }, out var validatedToken);

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Token validation failed: {ex.Message}");
                return false;
            }
        }
    }
    public class JwtSettings
    {
        public string SecretKey { get; set; } = null!;
        public string Issuer { get; set; } = null!;
        public string Audience { get; set; } = null!;
    }
    */
}
