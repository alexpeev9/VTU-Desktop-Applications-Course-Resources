namespace DailyTasksApplication.Database
{
    using Models;

    using Microsoft.EntityFrameworkCore;
    public class DailyTasksDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if(optionsBuilder.IsConfigured == false)
            {
                string connectionString = "Server=.;Database=DailyTasksDb;Integrated security=true;";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<Task>()
                .HasOne(t => t.User)
                .WithMany(u => u.Tasks)
                .HasForeignKey(t => t.UserId);

            modelBuilder
                .Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique(true);
        }
    }
}
