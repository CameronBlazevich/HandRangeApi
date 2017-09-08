using PBandJ.Api.Enums;

namespace PBandJ.Api.Models
{
    public class HandRangeDto
    {
        public int UserId { get; set; }
        public Position Position { get; set; }
        public string[] Hands { get; set; }
    }
}
