using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace taxes.services.Security
{
    public class PasswordHasher
    {
        private int saltSize = 32;
        private HashAlgorithm hash = new SHA256Managed();
        private static string pepper = "alaspiralax16";

        public string Salt { get; private set; }

        public string GenerateHash(string plainText, string salt = null)
        {
            if (String.IsNullOrEmpty(salt))
                GenerateSalt();
            else Salt = salt;

            string passSaltPepper = plainText + Salt + pepper;

            byte[] hashBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(passSaltPepper));
            return Convert.ToBase64String(hashBytes);
        }

        public bool VerifyHash(string plainText, string salt, string hashValue)
        {
            string hashFromPassword = GenerateHash(plainText, salt);
            return (hashValue == hashFromPassword);
        }

        private void GenerateSalt()
        {
            RNGCryptoServiceProvider rNG = new RNGCryptoServiceProvider();
            byte[] saltBytes = new byte[saltSize];
            rNG.GetNonZeroBytes(saltBytes);
            Salt = Convert.ToBase64String(saltBytes);
        }

    }
}
