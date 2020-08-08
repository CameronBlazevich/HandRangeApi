using PBandJ.Api.Models;
using PBandJ.Api.Repositories.Positions;

namespace PBandJ.Api.Services.Positions
{
    public class PositionService : IPositionService
    {
        private readonly IPositionRepository _positionRepository;

        public PositionService(IPositionRepository positionRepository)
        {
            _positionRepository = positionRepository;
        }
        public PositionDto CreatePosition(PositionDto position)
        {
            var entity = Mapper.MapToEntity(position);
            entity = _positionRepository.UpsertPosition(entity);
            return Mapper.MapToDto(entity);
        }

        public PositionDto GetPosition(PositionDto positionDto)
        {
            var position = _positionRepository.GetPositionOrDefault(positionDto);
            if (position != null)
            {
                return Mapper.MapToDto(position);
            }
            positionDto.HandRange = new HandRangeDto {Hands = new string[0]};
            return positionDto;
        }
    }
}