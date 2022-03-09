namespace FavoriteListApp.Database
{
	using Models;

	using Microsoft.EntityFrameworkCore;
    public class AppDbContext : DbContext
	{
		public DbSet<User> Users { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);

			if (optionsBuilder.IsConfigured == false)
			{
				optionsBuilder.UseSqlServer("Server=.;Database=FavoriteListDb1;Integrated security=true;");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			
			modelBuilder
				.Entity<User>()
				.HasIndex(u => u.Username)
				.IsUnique(true);
		}
	}
}
