using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PBandJ.Api.Models;
using PBandJ.Api.Models.Requests;
using PBandJ.Api.Services.Exceptions;
using PBandJ.Api.Services.HandRanges;

namespace PBandJ.Api.Controllers
{
    [Route("api/[controller]")]
    public class HandRangesController : PbAndJControllerBase
    {
        private readonly IHandRangeService _handRangeService;

        public HandRangesController(IHandRangeService handRangeService)
        {
            _handRangeService = handRangeService;
        }
        
        [HttpPost]
        [Authorize]
        public IActionResult UpsertHandRange([FromBody] UpdateHandRangeRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }
            
            try
            {
                var userId = FigureOutUserId();
                var handRangeDto = new HandRangeDto
                {
                    Hands = request.Hands,
                    UserId = userId,
                    PositionId = request.PositionKey.PositionId  
                };

                var result = _handRangeService.CreateOrUpdateHandRange(handRangeDto);

                return Ok(result);
            }
            catch (HandRangeServiceException ex)
            {
                //log
                return BadRequest(new {ex.Message});
            }
        }
        
        [Authorize]
        [HttpGet("{positionId}")]
        public IActionResult GetHandRange(int positionId)
        {          
            var userId = FigureOutUserId();

            var handRange = _handRangeService.GetHandRange(userId, positionId);
            return Ok(handRange);
        }
    }
}
