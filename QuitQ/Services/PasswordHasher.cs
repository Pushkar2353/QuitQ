using System.Security.Cryptography;
using System.Text;

namespace QuitQ.Services
{
    public interface IPasswordHasher
    {
        string HashPassword(string password);
        bool VerifyPassword(string providedPassword, string hashedPassword);
    }
    public class PasswordHasher : IPasswordHasher
    {
        public string HashPassword(string password)
        {
            using (var hmac = new HMACSHA256())
            {
                // Generate a salt and hash the password
                var salt = GenerateSalt();
                var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password + salt));
                return Convert.ToBase64String(hash) + ":" + salt;
            }
        }

        public bool VerifyPassword(string providedPassword, string hashedPassword)
        {
            // Split the stored hash into the hash and salt components
            var parts = hashedPassword.Split(':');
            if (parts.Length != 2) return false;

            var hash = parts[0];
            var salt = parts[1];

            // Recompute the hash with the provided password and the stored salt
            using (var hmac = new HMACSHA256())
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(providedPassword + salt));
                return hash == Convert.ToBase64String(computedHash);
            }
        }

        private string GenerateSalt()
        {
            // Generate a secure salt
            var saltBytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }
    }
}
