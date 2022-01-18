using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using PBandJ.Api.Entities;

namespace PBandJ.Api.Services.HandRanges.Parsing
{
    public static class PioHandRangeParser
    {
        public static HandRange Parse(string handRangeInput, ActionType actionType)
        {
            var handRange = new HandRange();
            var pattern = "(\\[....?.?.?.?\\])";
            var parts = Regex.Split(handRangeInput, pattern);

            var lastFreq = string.Empty;
            var lastHands = new HashSet<string>();

            var handsList = new List<HandAction>();
            foreach (var part in parts)
            {
                if (part.Length <= 2)
                {
                    continue;
                }
                if (part.Contains("[/"))
                {
                    //closing freq
                    AddHandActionsToHandsList(lastHands, handsList, lastFreq, actionType);
                    continue;
                }

                if (part.Contains("["))
                {
                    //opening freq
                    var freq = Regex.Match(part, "\\d\\d?\\.\\d?\\d?");
                    lastFreq = freq.Value;
                    continue;
                }

                if (part == parts.LastOrDefault())
                {
                    var fullFreqHands = GetHands(part);
                    AddHandActionsToHandsList(fullFreqHands, handsList, "100", actionType);
                }

                
                
                // pull hands out of 2d2h, 2s2h, 2c2h, 3h2h, 3d2h, 3s2h, 3c2h, 4h2h, 4d2h, 4s2h, 4c2h, 5h2h, 5d2h, 5s2h, 5c2h, 6h2h, 6d2h, etc.  
                lastHands = GetHands(part);
            }
            
            

            handRange.HandsArray = handsList.ToArray();
            return handRange;
        }

        private static void AddHandActionsToHandsList(HashSet<string> lastHands, List<HandAction> handsList, string frequency, ActionType actionType)
        {
            foreach (var hand in lastHands)
            {
                if (actionType == ActionType.Raise)
                {
                    handsList.Add(new HandAction(hand, decimal.Parse(frequency), null, null));
                }
                else if (actionType == ActionType.Call)
                {
                    handsList.Add(new HandAction(hand, null, decimal.Parse(frequency), null));
                }
            }
        }

        public static HashSet<string> GetHands(string handsCsv)
        {
            var hands = handsCsv.Split(", ");

            var summarizedHands = new HashSet<string>();
            foreach (var hand in hands)
            {
                if (hand.Length <= 2)
                {
                    continue;
                }
                var firstCardValue = hand[0];
                var firstCardSuit = hand[1];
                var secondCardValue = hand[2];
                var secondCardSuit = hand[3];

                var isSuited = firstCardSuit.Equals(secondCardSuit);
                var suitIndicator = isSuited ? "s" : "o";
                var handToAdd = $"{firstCardValue}{secondCardValue}{suitIndicator}";
                summarizedHands.Add(handToAdd);
            }

            return summarizedHands;

        }
    }
}