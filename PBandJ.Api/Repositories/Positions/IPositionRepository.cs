using PBandJ.Api.Entities;
using PBandJ.Api.Models;
using PBandJ.Api.Models.Requests;

namespace PBandJ.Api.Repositories.Positions
{
    public interface IPositionRepository
    {
        Position CreatePosition(Position entity);
        Position GetPositionOrDefault(PositionDto positionDto);
    }
}