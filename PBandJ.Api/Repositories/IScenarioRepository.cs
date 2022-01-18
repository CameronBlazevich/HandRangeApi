using PBandJ.Api.Entities;
using System.Collections.Generic;
using PBandJ.Api.Models;

namespace PBandJ.Api.Repositories
{
    public interface IScenarioRepository
    {
        Scenario CreateScenario(Scenario scenario);
        IEnumerable<Scenario> GetScenarios();
        IEnumerable<Scenario> GetUserScenarios(string userId);
        void UpdateScenario(Scenario scenarioToUpdate);
    }
}
