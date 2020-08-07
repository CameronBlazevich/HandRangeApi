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
        public DbSet<Situation> Situations { get; set; }
        public DbSet<Position> Positions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Scenario>().HasData()
            // modelBuilder.Entity<HandRange>()
            //     .HasKey(hr => new { hr.UserId, hr.Position });
        }
    }
}
