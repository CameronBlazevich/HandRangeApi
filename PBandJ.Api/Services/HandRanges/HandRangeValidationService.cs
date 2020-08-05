using System.Linq;
using PBandJ.Api.Enums;
using PBandJ.Api.Helpers.cs;
using PBandJ.Api.Services.Exceptions;

namespace PBandJ.Api.Services.HandRanges
{
    public class HandRangeValidationService : IHandRangeValidationService
    {
        public void VerifyHandRangeContainsOnlyValidHands(string[] handRangeHands)
        {
            var invalidHands = handRangeHands.Except(PossibleHands.HandsArray);
            var invalidHandsArray = invalidHands.EnumerateToStringArray();
            if (invalidHandsArray.Any())
            {
                var invalidHandsAsString = string.Join(",", invalidHandsArray);
                //Log
                throw new HandRangeServiceException($"Invalid hands: {invalidHandsAsString}");
            }
        }

        
    }
}
