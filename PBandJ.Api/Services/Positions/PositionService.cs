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
    }
}