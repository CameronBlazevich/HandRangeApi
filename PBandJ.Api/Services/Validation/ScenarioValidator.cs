using PBandJ.Api.Models;

namespace PBandJ.Api.Services.Validation
{
    public static class ScenarioValidator
    {
        public static bool IsValid(this ScenarioDto scenario)
        {
            if (scenario.Name.Length > 30)
            {
                return false;
            }

            return true;
        }
    }
}
