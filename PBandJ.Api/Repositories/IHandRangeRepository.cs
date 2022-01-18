using System.Collections.Generic;
using PBandJ.Api.Entities;
using PBandJ.Api.Enums;
using Position = PBandJ.Api.Entities.Position;

namespace PBandJ.Api.Repositories
{
    public interface IHandRangeRepository
    {
        HandRange AddHandRange(HandRange handRange);
        HandRange UpdateHandRange(HandRange handRange);
        HandRange GetHandRange(string userId, int positionId);
        IEnumerable<HandRange> GetHandRanges(string userId);
    }
}
