using System.Collections.Generic;
using PBandJ.Api.Entities;
using PBandJ.Api.Enums;

namespace PBandJ.Api.Repositories
{
    public interface IHandRangeRepository
    {
        HandRange AddHandRange(HandRange handRange);
        HandRange UpdateHandRange(HandRange handRange);
        HandRange GetHandRange(string userId, Position position);
        IEnumerable<HandRange> GetHandRanges(string userId);
    }
}
