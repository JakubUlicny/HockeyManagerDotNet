using Microsoft.EntityFrameworkCore;

namespace HockeyManager
{
    internal class HockeyManagerDbContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Stats> Stats { get; set; }

        public string DbPath { get; }

        public HockeyManagerDbContext()
        {
            var folder = System.Environment.SpecialFolder.LocalApplicationData;
            var path = System.Environment.GetFolderPath(folder);

            DbPath = System.IO.Path.Combine(path, "manager.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stats>()
                .Property(s => s.Assists)
                .HasDefaultValue(0);
            modelBuilder.Entity<Stats>()
                .Property(s => s.Goals)
                .HasDefaultValue(0);
            modelBuilder.Entity<Stats>()
                .Property(s => s.PlusMinus)
                .HasDefaultValue(0);
        }
    }
}
