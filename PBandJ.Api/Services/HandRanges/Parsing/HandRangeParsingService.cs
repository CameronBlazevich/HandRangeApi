
using PBandJ.Api.Entities;

namespace PBandJ.Api.Services.HandRanges.Parsing
{
    public static class HandRangeParsingService
    {
        public static HandRange ParseHandRange(string handRangeInput, ActionType actionType)
        {
            var formatting = InferRangeFormatting(handRangeInput);

            switch (formatting)
            {
                case RangeFormatting.Pio:
                default:
                    return PioHandRangeParser.Parse(handRangeInput, actionType);
            }
        }
        

        private static RangeFormatting InferRangeFormatting(string handRangeInput)
        {
            return RangeFormatting.Pio;
        }
        
    }

    public enum RangeFormatting
    {
        Pio
    }
}