using PBandJ.Api.Enums;
using PBandJ.Api.Helpers.cs;
using PBandJ.Api.Services.Exceptions;
using System.Linq;

namespace PBandJ.Api.Services
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
