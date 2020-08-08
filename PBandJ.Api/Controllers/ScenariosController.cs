using Microsoft.AspNetCore.Mvc;
using PBandJ.Api.Models;
using PBandJ.Api.Services;

namespace PBandJ.Api.Controllers
{
    [Route("api/[controller]")]
    public class ScenariosController : PbAndJControllerBase
    {
        private readonly IScenarioService _scenarioService;
        public ScenariosController(IScenarioService scenarioService)
        {
            _scenarioService = scenarioService;
        }

        [HttpGet]
        public IActionResult GetScenarios()
        {
            var userId = FigureOutUserId();
            var scenarios = _scenarioService.GetScenarios(userId);
            return Ok(scenarios);
        }

        [HttpPost]
        public IActionResult CreateScenario([FromBody] ScenarioDto scenario)
        {
            scenario.UserId = FigureOutUserId();
            scenario = _scenarioService.CreateScenario(scenario);
            return Ok(scenario);
        }

        
    }
}
