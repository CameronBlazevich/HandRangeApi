using PBandJ.Api.Entities;

namespace PBandJ.Api.Models
{
    public class HandRangeDto
    {
        public string UserId { get; set; }
        public int PositionId { get; set; }
        public HandAction[] Hands { get; set; }
    }
}