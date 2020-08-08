using PBandJ.Api.Entities;
using PBandJ.Api.Models;

namespace PBandJ.Api.Services.Positions
{
    public static class Mapper
    {
        public static PositionDto MapToDto(Position entity)
        {
            var dto = new PositionDto
            {
                Key = entity.Key,
                DisplayName = entity.DisplayName,
                HandRange = HandRanges.Mapper.MapEntityToDto(entity.HandRange),
                SituationId = entity.SituationId,
                Id = entity.Id
            };

            return dto;
        }

        public static Position MapToEntity(PositionDto dto)
        {
            var position = new Position
            {
                Key = dto.Key,
                DisplayName = dto.DisplayName,
                HandRange = HandRanges.Mapper.MapDtoToEntity(dto.HandRange),
                SituationId = dto.SituationId,
            };

            return position;
        }
    }
}