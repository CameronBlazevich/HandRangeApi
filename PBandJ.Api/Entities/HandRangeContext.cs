using System.Collections.Generic;
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
            var scenarios = new List<Scenario>
            {
                new Scenario {Id = 1, Name = "Open Opportunity"},
                new Scenario {Id = 2, Name = "3Bet Opportunity"}
            };

            modelBuilder.Entity<Scenario>().HasData(scenarios);
            
            var situations = new List<Situation>
            {
                new Situation {Id = 1, ScenarioId = 1, DisplayName = "Unopened Pot"},
                new Situation {Id = 2, ScenarioId = 2, DisplayName = "UTG Open"},
                new Situation {Id = 3, ScenarioId = 2, DisplayName = "HJ Open"},
                new Situation {Id = 4, ScenarioId = 2, DisplayName = "CO Open"},
                new Situation {Id = 5, ScenarioId = 2, DisplayName = "BTN Open"},
                new Situation {Id = 6, ScenarioId = 2, DisplayName = "SB Open"}
            };
            
            modelBuilder.Entity<Situation>().HasData(situations);

            var positions = new List<Position>
            {
                new Position(1, Enums.Position.UTG, 1),
                new Position(2, Enums.Position.HJ, 1),
                new Position(3, Enums.Position.CO, 1),
                new Position(4, Enums.Position.BTN, 1),
                new Position(5, Enums.Position.SB, 1),
                
                // 3-Bet Opportunities
                // UTG Open
                new Position(6, Enums.Position.HJ, 2),
                new Position(7, Enums.Position.CO, 2),
                new Position(8, Enums.Position.BTN, 2),
                new Position(9, Enums.Position.SB, 2),
                new Position(10, Enums.Position.BB, 2),
                // HJ OPen
                new Position(11, Enums.Position.CO, 3),
                new Position(12, Enums.Position.BTN, 3),
                new Position(13, Enums.Position.SB, 3),
                new Position(14, Enums.Position.BB, 3),
                // CO Open
                new Position(15, Enums.Position.BTN, 4),
                new Position(16, Enums.Position.SB, 4),
                new Position(17, Enums.Position.BB, 4),
                // BTN Open
                new Position(18, Enums.Position.SB, 5),
                new Position(19, Enums.Position.BB, 5),
                // SB Open
                new Position(20, Enums.Position.BB, 6),
            };
            modelBuilder.Entity<Position>().HasData(positions);
        }
    }
}