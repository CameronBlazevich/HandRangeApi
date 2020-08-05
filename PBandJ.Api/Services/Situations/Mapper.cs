using PBandJ.Api.Entities;
using PBandJ.Api.Models;

namespace PBandJ.Api.Services.Situations
{
    public static class Mapper
    {
        public static SituationDto MapToDto(Situation situation)
        {
            var situationDto = new SituationDto
            {
                DisplayName = situation.DisplayName,
                Id = situation.Id,
                ScenarioId = situation.ScenarioId
            };

            return situationDto;
        }

        public static Situation MapToEntity(SituationDto dto)
        {
            var entity = new Situation
            {
                DisplayName = dto.DisplayName,
                ScenarioId = dto.ScenarioId
            };

            return entity;
        }
    }
}