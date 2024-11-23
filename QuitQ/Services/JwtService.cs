using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace QuitQ.Services
{
    public class JwtService
    {
        private readonly IConfiguration _configuration;

        // Constructor injection of IConfiguration
        public JwtService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureJwtOptions()
        {
            // Access values from the appsettings.json or other config sources
            var key = _configuration["Jwt:Key"];
            var issuer = _configuration["Jwt:Issuer"];
            var audience = _configuration["Jwt:Audience"];

            // Example usage: Setting up JWT authentication
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidIssuer = issuer,
                ValidAudience = audience,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key))
            };

            // Further use tokenValidationParameters as needed
        }
    }
}
