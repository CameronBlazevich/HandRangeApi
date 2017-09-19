using System.Collections.Generic;
using PBandJ.Api.Models;

namespace PBandJ.Api.Services
{
    public interface IPositionService
    {
        PositionsDto GetAll();
    }
}