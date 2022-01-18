using System.Collections.Generic;
using System.Linq;
using PBandJ.Api.Entities;
using PBandJ.Api.Enums;
using PBandJ.Api.Services.Exceptions;

namespace PBandJ.Api.Services.HandRanges
{
    public class HandRangeValidationService : IHandRangeValidationService
    {
        public void VerifyHandRangeContainsOnlyValidHands(HandAction[] handRangeHands)
        {
            var invalidHands = handRangeHands.Where(x => !PossibleHands.HandsArray.Contains(x.Hand)).ToList();
            if (invalidHands.Any())
            {
                var invalidHandsAsString = string.Join(",", invalidHands.Select(x => x.Hand));
                //Log
                throw new HandRangeServiceException($"Invalid hands: {invalidHandsAsString}");
            }

            var handsWithInvalidFrequencies =
                handRangeHands.Where(x => x.ActionFrequencies.Sum(x => x.PercentFrequency) > 100).ToList();

            if (handsWithInvalidFrequencies.Any())
            {
                var invalidHandsAsString = string.Join(",", handsWithInvalidFrequencies.Select(x => x.Hand));
                //Log
                throw new HandRangeServiceException($"Invalid frequencies for hands: {invalidHandsAsString}");
            }
        }
        
        public HandAction[] SanitizeHands(HandAction[] hands)
        {
            hands = RemoveDuplicateHands(hands);
            VerifyHandRangeContainsOnlyValidHands(hands);
            return hands;
        }

        private static HandAction[] RemoveDuplicateHands(HandAction[] hands)
        {
            var handsHash = new HashSet<HandAction>(hands);
            var deDupedHands = new HandAction[handsHash.Count];
            handsHash.CopyTo(deDupedHands);
            return deDupedHands;
        }

        
    }
}
