using System.Collections.Generic;
using PBandJ.Api.Models;

namespace PBandJ.Api.Services.Scenarios
{
    public interface IScenarioService
    {
        IEnumerable<ScenarioDto> GetScenarios();
        IEnumerable<ScenarioDto> GetUserScenarios(string userId);
        ScenarioDto CreateScenario(ScenarioDto scenario);

    }
}
