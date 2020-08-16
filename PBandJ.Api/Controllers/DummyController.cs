using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PBandJ.Api.Entities;
using PBandJ.Api.Services.HandRanges;

namespace PBandJ.Api.Controllers
{
    public class DummyController: Controller
    {
        private readonly IHandRangeService _handRangeService;

        public DummyController(IHandRangeService handRangeService)
        {
            _handRangeService = handRangeService;
        }

        [Authorize]
        [HttpGet]
        [Route("api/testauth")]
        public IActionResult TestAuth()
        {
            return Ok("Authorized Endpoint");
        }

        [HttpGet]
        [Route("api/test")]
        public IActionResult Test()
        {
            return Ok("No-Auth Endpoint.");
        }

        // [HttpPost]
        // [Route("api/test")]
        // public IActionResult TestPost()
        // {
        //     _handRangeService.ConvertToHandAction();
        //     return Ok();
        // }
    }
}
