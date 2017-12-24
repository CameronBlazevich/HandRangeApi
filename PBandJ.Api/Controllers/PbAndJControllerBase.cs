using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;

namespace PBandJ.Api.Controllers
{
    public class PbAndJControllerBase: Controller
    {
        public string FigureOutUserId()
        {
            if (Debugger.IsAttached)
            {
                return "debugUser";
            }
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            return userId;
        }
    }
}
