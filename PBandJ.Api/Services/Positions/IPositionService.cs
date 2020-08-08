using PBandJ.Api.Models;

namespace PBandJ.Api.Services.Positions
{
    public interface IPositionService
    { 
        PositionDto UpsertPosition(PositionDto position);
        PositionDto GetPosition(PositionDto positionDto);
    }
}