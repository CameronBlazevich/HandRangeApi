using PBandJ.Api.Entities;
using PBandJ.Api.Models;
using System.Collections.Generic;

namespace PBandJ.Api.Services
{
    public interface IScenarioService
    {
        IEnumerable<ScenarioDto> GetScenarios(string userId);
        ScenarioDto CreateScenario(ScenarioDto scenario);
        ScenarioDto UpdateScenario(string userId, ScenarioDto scenario);
    }
}
