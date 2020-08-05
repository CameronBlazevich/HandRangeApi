using System.Collections.Generic;

namespace PBandJ.Api.Entities
{
    public class Situation
    {
        public int Id { get; set; }
        public int ScenarioId { get; set; }
        public string DisplayName { get; set; }
        public List<Position> HerosPositions  { get; set; }
    }
}