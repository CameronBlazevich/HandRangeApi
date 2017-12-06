using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PBandJ.Api.Entities;

namespace PBandJ.Api.Controllers
{
    public class DummyController: Controller
    {
        private HandRangeContext _ctx;

        public DummyController(HandRangeContext ctx)
        {
            _ctx = ctx;
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
    }
}
