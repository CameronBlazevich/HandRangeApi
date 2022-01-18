using System.Collections.Generic;
using PBandJ.Api.Entities;

namespace PBandJ.Api.Repositories.Positions
{
    public interface IPositionRepository
    {
        IEnumerable<Position> GetPositions(string userId);
    }
}