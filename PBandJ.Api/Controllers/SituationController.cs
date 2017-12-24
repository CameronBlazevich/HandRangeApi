using Microsoft.AspNetCore.Mvc;
using PBandJ.Api.Models;
using PBandJ.Api.Services;

namespace PBandJ.Api.Controllers
{
    [Route("api/[controller]")]
    public class SituationsController : PbAndJControllerBase
    {
        private readonly ISituationService _situationService;
        public SituationsController(ISituationService situationService)
        {
            _situationService = situationService;
        }

        [HttpGet]
        public IActionResult GetSituations()
        {
            var userId = FigureOutUserId();
            var situations = _situationService.GetSituations(userId);
            return Ok(situations);
        }

        [HttpPost]
        public IActionResult CreateSituation([FromBody] SituationDto situation)
        {
            situation.UserId = FigureOutUserId();
            situation = _situationService.CreateSituation(situation);
            return Ok(situation);
        }

        [HttpPatch]
        public IActionResult UpdateSituation([FromBody] SituationDto situation)
        {
            var userId = FigureOutUserId();
            var updatedSituation = _situationService.UpdateSituation(userId, situation);
            return Ok(updatedSituation);
        }
    }
}
