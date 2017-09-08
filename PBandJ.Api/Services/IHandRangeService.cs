using PBandJ.Api.Enums;
using PBandJ.Api.Models;

namespace PBandJ.Api.Services
{
    public interface IHandRangeService
    {
        void CreateOrUpdateHandRange(HandRangeDto handRangeDto);
        HandRangeDto GetHandRange(int userId, Position position);
    }
}