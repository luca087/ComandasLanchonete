using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

namespace ComandasLanchonete.Services
{
    public static class PasswordHasher
    {
        public static string GenerateHash(string password, string salt)
        {
            var slatByte = Convert.FromBase64String(salt);

            var hash = Convert.ToBase64String(KeyDerivation.Pbkdf2(
    password: password!,
    salt: slatByte,
    prf: KeyDerivationPrf.HMACSHA256,
    iterationCount: 100000,
    numBytesRequested: 256 / 8));


            return hash;
        }

        public static string GenerateSalt()
        {
            byte[] salt = RandomNumberGenerator.GetBytes(128 / 8);

            string cryptSalt = Convert.ToBase64String(salt);

            return cryptSalt;
        }
    }
}
