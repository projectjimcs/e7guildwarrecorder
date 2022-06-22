using E7GuildWarRecorder.Database.Configuration;
using E7GuildWarRecorder.Models;
using Microsoft.EntityFrameworkCore;

namespace E7GuildWarRecorder.Database

{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Match> match { get; set; }
        public DbSet<Hero> hero { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new HeroConfiguration());
        }
    }
}

