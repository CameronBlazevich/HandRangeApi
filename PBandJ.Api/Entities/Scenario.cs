﻿using System.Collections;
using System.Collections.Generic;

namespace PBandJ.Api.Entities
{
    public class Scenario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Situation> Situations { get; set; }
    }
}
