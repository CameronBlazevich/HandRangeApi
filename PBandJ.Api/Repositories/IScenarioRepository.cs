using PBandJ.Api.Entities;
using System.Collections.Generic;
using PBandJ.Api.Models;

namespace PBandJ.Api.Repositories
{
    public interface IScenarioRepository
    {
        Scenario CreateScenario(Scenario scenario);
        IEnumerable<Scenario> GetScenarios(string userId);
        Scenario GetScenario(string userId, int scenarioId);
        void UpdateScenario(Scenario scenarioToUpdate);
    }
}
