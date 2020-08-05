﻿using PBandJ.Api.Enums;

namespace PBandJ.Api.Models
{
    public class PositionDto
    {
        public int Id { get; set; }
        public int SituationId { get; set; }
        public HandRangeDto HandRange { get; set; }
        public string DisplayName { get; set; }
    }
}
