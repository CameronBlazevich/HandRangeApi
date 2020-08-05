using PBandJ.Api.Models;

namespace PBandJ.Api.Services.Positions
{
    public interface IPositionService
    { 
        PositionDto CreatePosition(PositionDto position);
    }
}