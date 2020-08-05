using PBandJ.Api.Entities;

namespace PBandJ.Api.Repositories.Positions
{
    public interface IPositionRepository
    {
        Position CreatePosition(Position entity);
    }
}