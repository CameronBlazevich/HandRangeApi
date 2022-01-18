using PBandJ.Api.Entities;

namespace PBandJ.Api.Models.Requests
{
    public class UpdateFormattedHandRangeRequest
    {
        public PositionCompositeKey PositionKey { get; set; }
        public Range[] Ranges { get; set; }
    }

    public class Range
    {
        public string FormattedHandRange { get; set; }
        public ActionType ActionType { get; set; }
    }
}