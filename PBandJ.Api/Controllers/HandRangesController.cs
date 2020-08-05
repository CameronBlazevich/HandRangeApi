using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PBandJ.Api.Enums;
using PBandJ.Api.Models;
using PBandJ.Api.Services;
using PBandJ.Api.Services.Exceptions;

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

        [Authorize]
        [HttpGet]
        public IActionResult GetHandRanges()
        {          
            var userId = FigureOutUserId();
            var handRanges = _handRangeService.GetHandRanges(userId);
            return Ok(handRanges);
        }

        // [HttpGet("{positionId}")]
        // public IActionResult GetHandRangeByPosition(int positionId)
        // {
        //     var userId = FigureOutUserId();
        //     var handRange = _handRangeService.GetHandRange(userId, (Position)positionId);
        //     return Ok(handRange);
        // }



        [HttpPost]
        [Authorize]
        public IActionResult CreateHandRange(
            [FromBody] HandRangeDto handRange)
        {
            if (handRange == null)
            {
                return BadRequest();
            }

            try
            {
                handRange.UserId = FigureOutUserId();
                handRange = _handRangeService.CreateOrUpdateHandRange(handRange);
            }
            catch (HandRangeServiceException ex)
            {
                //log
                return BadRequest(new {ex.Message});
            }

            return Ok(handRange);
        }
    }
}
