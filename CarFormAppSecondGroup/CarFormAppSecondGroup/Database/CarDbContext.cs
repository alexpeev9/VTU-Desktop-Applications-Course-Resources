using CarFormAppSecondGroup.Database.Model;
using Microsoft.EntityFrameworkCore;

namespace CarFormAppSecondGroup.Database
{
	public class CarDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			if (optionsBuilder.IsConfigured == false)
			{
				string connectionString = "Server=.;Database=CarSecondGroupDB2;Integrated security=true;";
				optionsBuilder.UseSqlServer(connectionString);
			}
		}

		DbSet<Car> Cars { get; set; }
		DbSet<User> Users { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

		}
	}
}
