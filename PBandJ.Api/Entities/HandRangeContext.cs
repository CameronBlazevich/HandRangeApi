using System.Collections.Generic;
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
                new Scenario {Id = 2, Name = "3Bet Opportunity"},
                new Scenario {Id = 3, Name = "BB Defense"},
                new Scenario {Id = 4, Name = "3Bet Defense"},
            };

            modelBuilder.Entity<Scenario>().HasData(scenarios);

            var situations = new List<Situation>
            {
                new Situation {Id = 1, ScenarioId = 1, DisplayName = "Unopened Pot"},
                
                // 3Bet Opportunity
                new Situation {Id = 2, ScenarioId = 2, DisplayName = "UTG Open"},
                new Situation {Id = 3, ScenarioId = 2, DisplayName = "HJ Open"},
                new Situation {Id = 4, ScenarioId = 2, DisplayName = "CO Open"},
                new Situation {Id = 5, ScenarioId = 2, DisplayName = "BTN Open"},
                new Situation {Id = 6, ScenarioId = 2, DisplayName = "SB Open"},
                
                // BB Defense
                new Situation {Id = 7, ScenarioId = 3, DisplayName = "UTG Open"},
                new Situation {Id = 8, ScenarioId = 3, DisplayName = "HJ Open"},
                new Situation {Id = 9, ScenarioId = 3, DisplayName = "CO Open"},
                new Situation {Id = 10, ScenarioId = 3, DisplayName = "BTN Open"},
                new Situation {Id = 11, ScenarioId = 3, DisplayName = "SB Open"},
                
                // 3Bet Defense
                new Situation {Id = 12, ScenarioId = 4, DisplayName = "BB 3Bet"},
                new Situation {Id = 13, ScenarioId = 4, DisplayName = "SB 3Bet"},
                new Situation {Id = 14, ScenarioId = 4, DisplayName = "BTN 3Bet"},
                new Situation {Id = 15, ScenarioId = 4, DisplayName = "CO 3Bet"},
                new Situation {Id = 16, ScenarioId = 4, DisplayName = "HJ 3Bet"},
            };

            modelBuilder.Entity<Situation>().HasData(situations);

            var positions = new List<Position>
            {
                // Open Opportunities
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


                // BB Defense
                new Position(21, Enums.Position.BB, 7),
                new Position(22, Enums.Position.BB, 8),
                new Position(23, Enums.Position.BB, 9),
                new Position(24, Enums.Position.BB, 10),
                new Position(25, Enums.Position.BB, 11),
                
                // 3Bet Defense
                // BB 3Bet
                new Position(26, Enums.Position.SB, 12),
                new Position(27, Enums.Position.BTN, 12),
                new Position(28, Enums.Position.CO, 12),
                new Position(29, Enums.Position.HJ, 12),
                new Position(30, Enums.Position.UTG, 12),
                // SB 3Bet
                new Position(31, Enums.Position.BTN, 13),
                new Position(32, Enums.Position.CO, 13),
                new Position(33, Enums.Position.HJ, 13),
                new Position(34, Enums.Position.UTG, 13),
                // BTN 3Bet
                new Position(35, Enums.Position.CO, 14),
                new Position(36, Enums.Position.HJ, 14),
                new Position(37, Enums.Position.UTG, 14),
                // CO 3Bet
                new Position(38, Enums.Position.HJ, 15),
                new Position(39, Enums.Position.UTG, 15),
                // HJ 3Bet
                new Position(40, Enums.Position.UTG, 16),
            };
            modelBuilder.Entity<Position>().HasData(positions);
            
            var preflopActions = new List<PreflopAction>
            {
                // 3Bet Opportunity
                // UTG Open
                new PreflopAction {PositionId = 6, Id = 1, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.UTG},
                new PreflopAction {PositionId = 7, Id = 2, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.UTG},
                new PreflopAction {PositionId = 8, Id = 3, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.UTG},
                new PreflopAction {PositionId = 9, Id = 4, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.UTG},
                new PreflopAction {PositionId = 10, Id = 5, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.UTG},
                // HJ Open
                new PreflopAction {PositionId = 11, Id = 6, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.HJ},
                new PreflopAction {PositionId = 12, Id = 7, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.HJ},
                new PreflopAction {PositionId = 13, Id = 8, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.HJ},
                new PreflopAction {PositionId = 14, Id = 9, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.HJ},
                // CO Open
                new PreflopAction {PositionId = 15, Id = 10, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.CO},
                new PreflopAction {PositionId = 16, Id = 11, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.CO},
                new PreflopAction {PositionId = 17, Id = 12, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.CO},
                // BTN Open
                new PreflopAction {PositionId = 18, Id = 13, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.BTN},
                new PreflopAction {PositionId = 19, Id = 14, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.BTN},
                // SB Open
                new PreflopAction {PositionId = 20, Id = 15, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.SB},

                
                // BB Defense
                new PreflopAction {PositionId = 21, Id = 16, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.UTG},
                new PreflopAction {PositionId = 22, Id = 17, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.HJ},
                new PreflopAction {PositionId = 23, Id = 18, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.CO},
                new PreflopAction {PositionId = 24, Id = 19, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.BTN}, 
                new PreflopAction {PositionId = 25, Id = 20, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.SB},
                
                // 3Bet Defense
                // BB 3Bet vs SB
                new PreflopAction {PositionId = 26, Id = 21, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.SB},
                new PreflopAction {PositionId = 26, Id = 22, ActionType = PreflopActionType.ThreeBet, ActorsPosition = Enums.Position.BB},
                // BB 3Bet vs BTN
                new PreflopAction {PositionId = 27, Id = 23, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.BTN},
                new PreflopAction {PositionId = 27, Id = 24, ActionType = PreflopActionType.ThreeBet, ActorsPosition = Enums.Position.BB},
                // BB 3Bet vs CO
                new PreflopAction {PositionId = 28, Id = 25, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.CO},
                new PreflopAction {PositionId = 28, Id = 26, ActionType = PreflopActionType.ThreeBet, ActorsPosition = Enums.Position.BB},
                // BB 3Bet vs HJ
                new PreflopAction {PositionId = 29, Id = 27, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.HJ},
                new PreflopAction {PositionId = 29, Id = 28, ActionType = PreflopActionType.ThreeBet, ActorsPosition = Enums.Position.BB},
                // BB 3Bet vs UTG
                new PreflopAction {PositionId = 30, Id = 29, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.UTG},
                new PreflopAction {PositionId = 30, Id = 30, ActionType = PreflopActionType.ThreeBet, ActorsPosition = Enums.Position.BB},
                
                // SB 3Bet vs BTN
                new PreflopAction {PositionId = 31, Id = 31, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.BTN},
                new PreflopAction {PositionId = 31, Id = 32, ActionType = PreflopActionType.ThreeBet, ActorsPosition = Enums.Position.SB},
                // SB 3Bet vs CO
                new PreflopAction {PositionId = 32, Id = 33, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.CO},
                new PreflopAction {PositionId = 32, Id = 34, ActionType = PreflopActionType.ThreeBet, ActorsPosition = Enums.Position.SB},
                // SB 3Bet vs HJ
                new PreflopAction {PositionId = 33, Id = 35, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.HJ},
                new PreflopAction {PositionId = 33, Id = 36, ActionType = PreflopActionType.ThreeBet, ActorsPosition = Enums.Position.SB},
                // SB 3Bet vs UTG
                new PreflopAction {PositionId = 34, Id = 37, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.UTG},
                new PreflopAction {PositionId = 34, Id = 38, ActionType = PreflopActionType.ThreeBet, ActorsPosition = Enums.Position.SB},
                
                // BTN 3Bet vs CO
                new PreflopAction {PositionId = 35, Id = 39, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.CO},
                new PreflopAction {PositionId = 35, Id = 40, ActionType = PreflopActionType.ThreeBet, ActorsPosition = Enums.Position.BTN},
                // BTN 3Bet vs HJ
                new PreflopAction {PositionId = 36, Id = 41, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.HJ},
                new PreflopAction {PositionId = 36, Id = 42, ActionType = PreflopActionType.ThreeBet, ActorsPosition = Enums.Position.BTN},
                // BTN 3Bet vs UTG
                new PreflopAction {PositionId = 37, Id = 43, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.UTG},
                new PreflopAction {PositionId = 37, Id = 44, ActionType = PreflopActionType.ThreeBet, ActorsPosition = Enums.Position.BTN},
                
                // CO 3Bet vs HJ
                new PreflopAction {PositionId = 38, Id = 45, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.HJ},
                new PreflopAction {PositionId = 38, Id = 46, ActionType = PreflopActionType.ThreeBet, ActorsPosition = Enums.Position.CO},
                // CO 3Bet vs UTG
                new PreflopAction {PositionId = 39, Id = 47, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.UTG},
                new PreflopAction {PositionId = 39, Id = 48, ActionType = PreflopActionType.ThreeBet, ActorsPosition = Enums.Position.CO},
                
                // HJ 3Bet vs UTG
                new PreflopAction {PositionId = 40, Id = 49, ActionType = PreflopActionType.Open, ActorsPosition = Enums.Position.UTG},
                new PreflopAction {PositionId = 40, Id = 50, ActionType = PreflopActionType.ThreeBet, ActorsPosition = Enums.Position.HJ},
                
            };

            modelBuilder.Entity<PreflopAction>().HasData(preflopActions);
        }
    }
}