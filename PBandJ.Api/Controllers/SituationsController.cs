using Microsoft.AspNetCore.Mvc;
using PBandJ.Api.Models;
using PBandJ.Api.Services.Situations;

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
        
        [HttpPost]
        public IActionResult CreateSituation([FromBody] SituationDto situation)
        {
            situation = _situationService.CreateSituation(situation);
            return Ok(situation);
        }
    }
}