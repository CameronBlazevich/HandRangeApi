using Microsoft.EntityFrameworkCore;

namespace PBandJ.Api.Entities
{
    public sealed class HandRangeContext : DbContext
    {
        public HandRangeContext(DbContextOptions<HandRangeContext> options) : base(options)
        {
            Database.Migrate();
        }
        public DbSet<HandRange> HandRanges { get; set; }
        public DbSet<Scenario> Scenarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HandRange>()
                .HasKey(hr => new { hr.UserId, hr.Position });
        }
    }
}
