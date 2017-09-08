using Microsoft.AspNetCore.Mvc;
using PBandJ.Api.Enums;
using PBandJ.Api.Models;
using PBandJ.Api.Services;
using PBandJ.Api.Services.Exceptions;

namespace PBandJ.Api.Controllers
{
    [Route("api/[controller]")]
    public class HandRangesController : Controller
    {
        private readonly IHandRangeService _handRangeService;
        public HandRangesController(IHandRangeService handRangeService)
        {
            _handRangeService = handRangeService;
        }
        [HttpGet]
        public IActionResult GetAllHandRanges()
        {


            //using (var writer = new StreamWriter("WriteMyCode.txt"))
            //{
            //    foreach (var hand in PossibleHands.Possiblities)
            //    {
            //        writer.WriteLine($"\"{hand.DisplayValue}\", ");
            //    }
            //}


            return Ok();
        }

        [HttpGet("{positionId}")]
        public IActionResult GetHandRangeByPosition(int positionId)
        {
            var userId = FigureOutUserId();
            var handRange = _handRangeService.GetHandRange(userId, (Position)positionId);
            return Ok(handRange);
        }

        private int FigureOutUserId()
        {
            return 0;
        }

        [HttpPost]
        public IActionResult CreateHandRange(
            [FromBody] HandRangeDto handRange)
        {
            if (handRange == null)
            {
                return BadRequest();
            }

            try
            {
                _handRangeService.CreateOrUpdateHandRange(handRange);
            }
            catch (HandRangeServiceException ex)
            {
                //log
                return BadRequest(new {ex.Message});
            }

            return Ok();
        }
    }
}
