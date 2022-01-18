using PBandJ.Api.Entities;

namespace PBandJ.Api.Models
{
    public class FormattedHandRangeDto
    {
        public string UserId { get; set; }
        public int PositionId { get; set; }
        public string FormattedHands { get; set; }
        public ActionType ActionType { get; set; }
    }
}