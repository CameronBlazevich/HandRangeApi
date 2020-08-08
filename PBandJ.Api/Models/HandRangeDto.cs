namespace PBandJ.Api.Models
{
    public class HandRangeDto
    {
        public string UserId { get; set; }
        public int PositionId { get; set; }
        public string[] Hands { get; set; }
    }
}