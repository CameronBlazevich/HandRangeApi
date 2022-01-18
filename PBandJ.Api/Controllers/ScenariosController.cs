using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PBandJ.Api.Models;
using PBandJ.Api.Services.Scenarios;

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
            var scenarios = _scenarioService.GetScenarios();
            return Ok(scenarios);
        }
        
        [Authorize]
        [HttpGet("[action]")]
        public IActionResult GetUserScenarios()
        {
            var userId = FigureOutUserId();
            var scenarios = _scenarioService.GetUserScenarios(userId);
            return Ok(scenarios);
        }

        [Authorize]
        [HttpPost]
        public IActionResult CreateScenario([FromBody] ScenarioDto scenario)
        {
            scenario.UserId = FigureOutUserId();
            scenario = _scenarioService.CreateScenario(scenario);
            return Ok(scenario);
        }
    }
}
