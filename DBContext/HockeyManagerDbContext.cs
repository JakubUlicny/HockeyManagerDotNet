using Microsoft.EntityFrameworkCore;

namespace HockeyManager
{
    internal class HockeyManagerDbContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Stats> Stats { get; set; }

        public string DbPath { get; }

        public HockeyManagerDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);

            DbPath = Path.Combine(path, "manager.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");

    }
}
