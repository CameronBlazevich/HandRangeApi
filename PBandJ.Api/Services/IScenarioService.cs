using PBandJ.Api.Entities;
using PBandJ.Api.Models;
using System.Collections.Generic;

namespace PBandJ.Api.Services
{
    public interface IScenarioService
    {
        IEnumerable<ScenarioDto> GetScenarios();
        IEnumerable<ScenarioDto> GetUserScenarios(string userId);
        ScenarioDto CreateScenario(ScenarioDto scenario);

    }
}
