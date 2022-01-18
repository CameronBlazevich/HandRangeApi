using System.Collections.Generic;
using PBandJ.Api.Models;

namespace PBandJ.Api.Services.HandRanges
{
    public interface IHandRangeService
    {
        HandRangeDto CreateOrUpdateHandRange(HandRangeDto handRangeDto);
        HandRangeDto GetHandRange(string userId, int positionId);
        IEnumerable<HandRangeDto> GetHandRanges(string userId);
        // void ConvertToHandAction();
    }
}