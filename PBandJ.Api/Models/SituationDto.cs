using System.Collections.Generic;
using PBandJ.Api.Entities;
using Position = PBandJ.Api.Enums.Position;

namespace PBandJ.Api.Models
{
    public class SituationDto
    {
        public int Id { get; set; }
        public int ScenarioId { get; set; }
        public string DisplayName { get; set; }
        public List<PositionDto> Positions { get; set; }
    }
}