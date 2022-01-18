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
    }
}