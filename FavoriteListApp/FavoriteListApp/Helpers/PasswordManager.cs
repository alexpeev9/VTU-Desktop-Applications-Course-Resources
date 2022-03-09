namespace FavoriteListApp.Helpers
{
    using System;
    using System.Security.Cryptography;

    using Microsoft.AspNetCore.Cryptography.KeyDerivation;
    public class PasswordManager
    {
		public static string HashPassword(string password, string salt)
		{
			// derive a 256-bit subkey (use HMACSHA256 with 100,000 iterations)
			string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
					password: password,
					salt: Convert.FromBase64String(salt),
					prf: KeyDerivationPrf.HMACSHA256,
					iterationCount: 100000,
					numBytesRequested: 256 / 8));

			return hashed;
		}

		public static string GenerateSalt()
		{
			byte[] salt = new byte[128 / 8];
			using (var rngCsp = new RNGCryptoServiceProvider())
			{
				rngCsp.GetNonZeroBytes(salt);
			}

			return Convert.ToBase64String(salt);
		}
	}
}
