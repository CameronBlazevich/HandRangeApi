using PBandJ.Api.Entities;
using PBandJ.Api.Models;

namespace PBandJ.Api.Services.HandRanges
{
    public static class Mapper
    {
        public static HandRangeDto MapEntityToDto(HandRange handRange)
        {
            if (handRange == null)
            {
                return  new HandRangeDto();
            }
            
            var handRangeDto = new HandRangeDto
            {
                Hands = handRange.HandsArray,
                UserId = handRange.UserId,
                PositionId = handRange.PositionId
            };

            return handRangeDto;
        }
        
        public static HandRange MapDtoToEntity(HandRangeDto handRangeDto)
        {
            var handRange = new HandRange
            {
                HandsArray = handRangeDto.Hands,
                UserId = handRangeDto.UserId,
                PositionId = handRangeDto.PositionId
            };
            return handRange;
        }
    }
}