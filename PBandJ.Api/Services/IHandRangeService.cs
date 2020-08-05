using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PBandJ.Api.Enums;
using PBandJ.Api.Models;

namespace PBandJ.Api.Services
{
    public interface IHandRangeService
    {
        HandRangeDto CreateOrUpdateHandRange(HandRangeDto handRangeDto);
        HandRangeDto GetHandRange(string userId, int positionId);
        IEnumerable<HandRangeDto> GetHandRanges(string userId);
    }
}