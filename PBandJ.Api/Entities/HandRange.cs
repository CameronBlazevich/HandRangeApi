using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using PBandJ.Api.Enums;

namespace PBandJ.Api.Entities
{
    public class HandRange
    {
        public string UserId { get; set; }

        public int Id { get; set; }
        public int PositionId { get; set; }
        public string Hands { get; set; }

        [NotMapped]
        public string[] HandsArray
        {
            get => Hands == null ? new string[0] : JsonConvert.DeserializeObject<string[]>(Hands);
            set => Hands = JsonConvert.SerializeObject(value);
        }
    }
}
