using System.Collections.Generic;
using Position = PBandJ.Api.Enums.Position;

namespace PBandJ.Api.Models
{
    public class SituationDto
    {
        public int Id { get; set; }
        public int ScenarioId { get; set; }
        public string DisplayName { get; set; }
        public Position? OpenerPosition { get; set; }
        public List<PositionDto> Positions { get; set; }
    }
}