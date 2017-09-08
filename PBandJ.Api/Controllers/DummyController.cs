using System.Security.Cryptography.X509Certificates;
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

        [HttpGet]
        [Route("api/testdatabase")]
        public IActionResult TestDatabase()
        {
            return Ok();
        }
    }
}
