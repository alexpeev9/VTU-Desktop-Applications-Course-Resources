using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFormAppSecondGroup.Database.Model
{
	public class User
	{
		public User()
		{
			CreatedAt = DateTime.UtcNow;
		}
		[Key]
		public Guid Id { get; set; }
		public string Username { get; set; }
		public string PasswordHash { get; set; }
		public string Salt { get; set; }
		public DateTime CreatedAt { get; set; }
	}
}
