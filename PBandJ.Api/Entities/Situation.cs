using System.Collections.Generic;

namespace PBandJ.Api.Entities
{
    public class Situation
    {
        public int Id { get; set; }
        public int ScenarioId { get; set; }
        public string DisplayName { get; set; }
        public IEnumerable<Position> Positions  { get; set; }
        public Enums.Position? OpenerPosition { get; set; }
    }
}