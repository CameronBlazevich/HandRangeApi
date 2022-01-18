using PBandJ.Api.Entities;

namespace PBandJ.Api.Services.HandRanges
{
    public interface IHandRangeValidationService
    {
        void VerifyHandRangeContainsOnlyValidHands(HandAction[] handRange);
        HandAction[] SanitizeHands(HandAction[] hands);
    }
}