using System.Collections.Generic;
using PBandJ.Api.Entities;

namespace PBandJ.Api.Repositories.Situations
{
    public interface ISituationRepository
    {
        Situation CreateSituation(Situation situation);
        IEnumerable<Situation> GetSituations(int scenarioId);
        Situation GetSituationOrDefault(int situationId);
        void UpdateSituation(Situation situationToUpdate);
    }
}