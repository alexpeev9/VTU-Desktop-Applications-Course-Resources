namespace BookApp.DbContext
{
	using BookApp.Helpers;
	using BookApp.Models;
    using Microsoft.EntityFrameworkCore;
	using System;

	public class BookDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if(optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=BookDatabase5;Integrated security=true;");
            }
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			var salt = PasswordManager.GenerateSalt();

			modelBuilder.Entity<User>().HasData(
				new User
				{
					Id = 1,
					Username = "MockUser",
					Salt = salt,
					PasswordHash = PasswordManager.HashPassword("12345", salt),
					CreatedAt = DateTime.UtcNow
				});

			modelBuilder.Entity<Book>().HasData(
				new Book
				{
					Id = 1,
					Title = "Back to the Past",
					ReleaseYear = 2005,
					CreatedAt = DateTime.UtcNow,
					UserId = 1
				},
				new Book
				{
					Id = 2,
					Title = "Healer Newsday",
					ReleaseYear = 2010,
					CreatedAt = DateTime.UtcNow,
					UserId = 1
				});
		}
	}
}
