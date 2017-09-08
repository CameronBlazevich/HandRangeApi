using PBandJ.Api.Models;

namespace PBandJ.Api.Services
{
    public interface IHandRangeValidationService
    {
        void VerifyHandRangeContainsOnlyValidHands(string[] handRange);
    }
}