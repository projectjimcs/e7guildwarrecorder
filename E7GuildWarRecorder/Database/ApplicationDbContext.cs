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

		public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
			var insertedEntries = this.ChangeTracker.Entries()
								   .Where(x => x.State == EntityState.Added)
								   .Select(x => x.Entity);
			foreach (var insertedEntry in insertedEntries)
			{
				var auditableEntity = insertedEntry as Auditable;
				//If the inserted object is an Auditable. 
				if (auditableEntity != null)
				{
					auditableEntity.CreatedAt = DateTime.UtcNow;
				}
			}
			var modifiedEntries = this.ChangeTracker.Entries()
					   .Where(x => x.State == EntityState.Modified)
					   .Select(x => x.Entity);
			foreach (var modifiedEntry in modifiedEntries)
			{
				//If the inserted object is an Auditable. 
				var auditableEntity = modifiedEntry as Auditable;
				if (auditableEntity != null)
				{
					auditableEntity.UpdatedAt = DateTime.UtcNow;
				}
			}
			return base.SaveChangesAsync(cancellationToken);
		}
	}
}

