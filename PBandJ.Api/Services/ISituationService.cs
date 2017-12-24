using PBandJ.Api.Entities;
using PBandJ.Api.Models;
using System.Collections.Generic;

namespace PBandJ.Api.Services
{
    public interface ISituationService
    {
        IEnumerable<SituationDto> GetSituations(string userId);
        SituationDto CreateSituation(SituationDto situation);
        SituationDto UpdateSituation(string userId, SituationDto situation);
    }
}
