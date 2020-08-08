using System;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PBandJ.Api.Enums;
using PBandJ.Api.Models;
using PBandJ.Api.Models.Requests;
using PBandJ.Api.Services;
using PBandJ.Api.Services.Exceptions;
using PBandJ.Api.Services.HandRanges;
using PBandJ.Api.Services.Positions;

namespace PBandJ.Api.Controllers
{
    [Route("api/[controller]")]
    public class HandRangesController : PbAndJControllerBase
    {
        private readonly IHandRangeService _handRangeService;
        private readonly IPositionService _positionService;

        public HandRangesController(IHandRangeService handRangeService, IPositionService positionService)
        {
            _handRangeService = handRangeService;
            _positionService = positionService;
        }
        

        [HttpPost]
        [Authorize]
        public IActionResult CreateHandRange(
            [FromBody] UpdateHandRangeRequest request)
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
                    Hands = request.Hands
                };
                var positionDto = new PositionDto
                {
                    Key = request.PositionKey.PositionKey,
                    DisplayName = request.PositionKey.PositionKey.ToString(),
                    HandRange = handRangeDto,
                    SituationId = request.PositionKey.SituationId,
                    UserId = userId
                };

                var result = _positionService.UpsertPosition(positionDto);

                return Ok(result);
            }
            catch (HandRangeServiceException ex)
            {
                //log
                return BadRequest(new {ex.Message});
            }

        }
    }
}
