namespace PBandJ.Api.Entities
{
    public class Position
    {
        public int Id { get; set; }
        public int SituationId { get; set; }
        public Enums.Position PositionEnum { get; set; }
        public string DisplayName { get; set; }
        public HandRange HandRange { get; set; }
    }
}
