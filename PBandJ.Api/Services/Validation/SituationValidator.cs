using PBandJ.Api.Models;

namespace PBandJ.Api.Services.Validation
{
    public static class SituationValidator
    {
        public static bool IsValid(this SituationDto situation)
        {
            if (situation.Name.Length > 30)
            {
                return false;
            }

            return true;
        }
    }
}
