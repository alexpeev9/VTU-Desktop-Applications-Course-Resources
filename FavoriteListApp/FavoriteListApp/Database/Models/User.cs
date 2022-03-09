namespace FavoriteListApp.Database.Models
{
	using System;
    using System.ComponentModel.DataAnnotations;

    public class User
    {
		public User()
		{
			this.CreatedAt = DateTime.UtcNow;
		}

		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(32)]
		public string Username { get; set; }

		[Required]
		public string PasswordHash { get; set; }

		[Required]
		public string Salt { get; set; }

		public DateTime CreatedAt { get; set; }

	}
}
