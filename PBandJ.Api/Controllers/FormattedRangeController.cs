using Microsoft.AspNetCore.Mvc;
using PBandJ.Api.Models.Requests;
using PBandJ.Api.Services.HandRanges;

namespace PBandJ.Api.Controllers
{
    [Route("api/[controller]")]
    public class FormattedRangeController : PbAndJControllerBase
    {
        private readonly IFormattedHandRangeService _formattedHandRangeService;

        public FormattedRangeController(IFormattedHandRangeService formattedHandRangeService)
        {
            _formattedHandRangeService = formattedHandRangeService;
        }
        
        [HttpPost]
        public IActionResult UpsertHandRange([FromBody] UpdateFormattedHandRangeRequest request)
        {
            if (request == null)
            {
                return BadRequest("Unable to parse request");
            }

            var userId = FigureOutUserId();
            

            var result = _formattedHandRangeService.CreateOrUpdateHandRange(request, userId);
            return Ok(result);
        }
    }
}