using PBandJ.Api.Entities;
using PBandJ.Api.Enums;

namespace PBandJ.Api.Services
{
    public interface IHandRangeRepository
    {
        void AddHandRange(HandRange handRange);
        void UpdateHandRange(HandRange handRange);
        HandRange GetHandRange(int userId, Position position);
    }
}
