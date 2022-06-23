using E7GuildWarRecorder.Database.Configuration;
using E7GuildWarRecorder.Models;
using Microsoft.EntityFrameworkCore;

namespace E7GuildWarRecorder.Database

{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Match> Match { get; set; }
        public DbSet<Hero> Hero { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new HeroConfiguration());
        }
    }
}

