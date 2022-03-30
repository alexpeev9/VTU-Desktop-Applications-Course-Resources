using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Helpers
{
	public class PasswordManager
	{
		public static string HashPassword(string password, string salt)
		{
			string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
					password: password,
					salt: Convert.FromBase64String(salt),
					prf: KeyDerivationPrf.HMACSHA256,
					iterationCount: 10000,
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
