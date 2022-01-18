using System.ComponentModel.DataAnnotations.Schema;

namespace PBandJ.Api.Entities
{
    public class PreflopAction
    {
        public int Id { get; set; }
        public int PositionId { get; set; }
        public PreflopActionType ActionType { get; set; }
        public Enums.Position ActorsPosition { get; set; }

        [NotMapped]
        public HandRange HandRange { get; set; }
    }
    
    public enum PreflopActionType
    {
        Open, 
        ThreeBet,
        FourBet,
        FiveBet,
        Call,
    }
}