namespace PBandJ.Api.Services.HandRanges
{
    public interface IHandRangeValidationService
    {
        void VerifyHandRangeContainsOnlyValidHands(string[] handRange);
    }
}