using System.Collections.Generic;

namespace PBandJ.Api.Models
{
    public class ScenarioDto
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public List<SituationDto> Situations { get; set; }
    }
}
