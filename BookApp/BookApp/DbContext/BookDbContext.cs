namespace BookApp.DbContext
{
    using BookApp.Models;
    using Microsoft.EntityFrameworkCore;
    public class BookDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if(optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=BookDatabase1;Integrated security=true;");
            }
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder
				.Entity<Book>()
				.HasOne(t => t.User)
				.WithMany(u => u.Books)
				.HasForeignKey(t => t.UserId);
		}
	}
}
