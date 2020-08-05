using PBandJ.Api.Entities;
using PBandJ.Api.Models;

namespace PBandJ.Api.Services.HandRanges
{
    public static class Mapper
    {
        public static HandRangeDto MapEntityToDto(HandRange handRange)
        {
            var handRangeDto = new HandRangeDto
            {
                Hands = handRange.HandsArray,
            };

            return handRangeDto;
        }
        
        public static HandRange MapDtoToEntity(HandRangeDto handRangeDto)
        {
            var handRange = new HandRange
            {
                HandsArray = handRangeDto.Hands,
            };
            return handRange;
        }
    }
}