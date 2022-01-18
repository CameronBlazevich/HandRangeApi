using System.Collections.Generic;
using PBandJ.Api.Entities;
using Position = PBandJ.Api.Enums.Position;

namespace PBandJ.Api.Models
{
    public class PositionDto
    {
        public int Id { get; set; }
        public Position Key { get; set; }
        public int SituationId { get; set; }
        public HandRangeDto HandRange { get; set; }
        public List<PreflopAction> PreflopActions { get; set; }
        public string DisplayName { get; set; }
        public string UserId { get; set; }
    }
}
