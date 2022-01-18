using System.Collections.Generic;

namespace PBandJ.Api.Entities
{
    public class Position
    {
        public int Id { get; set; }
        public int SituationId { get; set; }
        public Enums.Position Key { get; set; }
        public string DisplayName { get; set; }
        public HandRange HandRange { get; set; }
        public List<PreflopAction> PreflopActions { get; set; }
        
        public Position()
        {
                
        }

        public Position(int id, Enums.Position key, int situationId)
        {
            Id = id;
            DisplayName = key.ToString();
            Key = key;
            SituationId = situationId;
        }
    }
}
