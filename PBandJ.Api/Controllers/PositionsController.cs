using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PBandJ.Api.Enums;
using PBandJ.Api.Models;
using PBandJ.Api.Services;
using PBandJ.Api.Services.Positions;

namespace PBandJ.Api.Controllers
{
    [Route("api/[controller]")]
    public class PositionsController : PbAndJControllerBase
    {
        private readonly IPositionService _positionService;

        public PositionsController(IPositionService positionService)
        {
            _positionService = positionService;
        }

        [HttpPost]
        public IActionResult UpsertPosition([FromBody] PositionDto position)
        {
            var result = _positionService.UpsertPosition(position);
            return Ok(result);
        }
        
        [Authorize]
        [HttpGet]
        public IActionResult GetPosition([FromQuery]string situationId, string positionKey)
        {          
            var userId = FigureOutUserId();
            var positionDto = new PositionDto
            {
                Key = Enum.Parse<Position>(positionKey),
                SituationId = int.Parse(situationId),
                UserId = userId
            };
            var position = _positionService.GetPosition(positionDto);
            return Ok(position);
        }
    }
}