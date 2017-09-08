using Microsoft.AspNetCore.Mvc;
using PBandJ.Api.Enums;

namespace PBandJ.Api.Controllers
{
    [Route("api/[controller]")]
    public class HandsController : Controller
    {
        [HttpGet]
        public IActionResult GetAllHands()
        {
            return Ok(PossibleHands.HandsArray);
        }
    }
}
