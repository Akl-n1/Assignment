using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Services
{
    public static class PasswordHasher
    {
        private const int SaltSize = 16;
        private const int KeySize = 32;
        private const int Iterations = 100_000;

        public static string Hash(string password)
        {
            using var rng = RandomNumberGenerator.Create();
            byte[] salt = new byte[SaltSize];
            rng.GetBytes(salt);
            using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256);
            var key = pbkdf2.GetBytes(KeySize);

            var hashBytes = new byte[1 + 4 + SaltSize + KeySize];
            int idx = 0;
            hashBytes[idx++] = 0;
            Array.Copy(BitConverter.GetBytes(Iterations), 0, hashBytes, idx, 4); idx += 4;
            Array.Copy(salt, 0, hashBytes, idx, SaltSize); idx += SaltSize;
            Array.Copy(key, 0, hashBytes, idx, KeySize);
            return Convert.ToBase64String(hashBytes);
        }

        public static bool Verify(string password, string hashed)
        {
            try
            {
                var hashBytes = Convert.FromBase64String(hashed);
                int idx = 0;
                var version = hashBytes[idx++];
                var iter = BitConverter.ToInt32(hashBytes, idx); idx += 4;
                var salt = new byte[SaltSize]; Array.Copy(hashBytes, idx, salt, 0, SaltSize); idx += SaltSize;
                var key = new byte[KeySize]; Array.Copy(hashBytes, idx, key, 0, KeySize);

                using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iter, HashAlgorithmName.SHA256);
                var keyToCheck = pbkdf2.GetBytes(KeySize);

                return CryptographicOperations.FixedTimeEquals(keyToCheck, key);
            }
            catch { return false; }
        }
    }
}
