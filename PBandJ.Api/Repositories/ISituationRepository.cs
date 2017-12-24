using PBandJ.Api.Entities;
using System.Collections.Generic;
using PBandJ.Api.Models;

namespace PBandJ.Api.Repositories
{
    public interface ISituationRepository
    {
        Situation CreateSituation(Situation situation);
        IEnumerable<Situation> GetSituations(string userId);
        Situation GetSituation(string userId, int situationId);
        void UpdateSituation(Situation situationToUpdate);
    }
}
