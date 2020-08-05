using PBandJ.Api.Enums;
using PBandJ.Api.Models;
using System;
using System.Collections.Generic;
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
            entity = _positionRepository.CreatePosition(entity);
            return Mapper.MapToDto(entity);
        }
    }
}