using System.Collections;
using System.Collections.Generic;

namespace PBandJ.Api.Entities
{
    public class Scenario
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public IEnumerable<PositionMenu> PositionMenus { get; set; }
    }
}
