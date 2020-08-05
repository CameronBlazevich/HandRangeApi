using System.Collections.Generic;
using PBandJ.Api.Models;

namespace PBandJ.Api.Services.Situations
{
    public interface ISituationService
    {
        IEnumerable<SituationDto> GetSituations(int scenarioId);
        SituationDto CreateSituation(SituationDto situation);
        SituationDto UpdateSituation(string userId, SituationDto situation);
    }
}