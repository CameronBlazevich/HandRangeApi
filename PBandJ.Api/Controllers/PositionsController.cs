using System;
using Microsoft.AspNetCore.Mvc;
using PBandJ.Api.Services;

namespace PBandJ.Api.Controllers
{
    [Route("api/[controller]")]
    public class PositionsController: Controller
    {
        private readonly IPositionService _positionService;
        public PositionsController(IPositionService positionService)
        {
            _positionService = positionService;
        }
        [HttpGet]
        public IActionResult GetPositions()
        {
            try
            {
                var positions = _positionService.GetAll();
                return Ok(positions);
            }
            catch (Exception ex)
            {
                //log
                return StatusCode(500);
            }
        }

    }
}
