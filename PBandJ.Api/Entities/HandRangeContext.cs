using Microsoft.AspNetCore.Identity;
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

            modelBuilder.Entity<Scenario>().HasData(
                new Scenario {Id = 1, Name = "Open Opportunity"},
                new Scenario {Id = 2, Name = "3Bet Opportunity"});
            
            modelBuilder.Entity<Situation>().HasData(
                new Situation {Id = 1, ScenarioId = 1, DisplayName = "Unopened Pot"},
                new Situation{Id = 2, ScenarioId = 2, DisplayName = "UTG Open"},
                new Situation{Id = 3, ScenarioId = 2, DisplayName = "HJ Open"},
                new Situation{Id = 4, ScenarioId = 2, DisplayName = "CO Open"},
                new Situation{Id = 5, ScenarioId = 2, DisplayName = "BTN Open"},
                new Situation{Id = 6, ScenarioId = 2, DisplayName = "SB Open"}
            );


            // modelBuilder.Entity<HandRange>()
            //     .HasKey(hr => new { hr.UserId, hr.Position });
        }
    }
}
