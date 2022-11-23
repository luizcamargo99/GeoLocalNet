﻿using System.Collections.Generic;

namespace GeoLocalNet.CountryLookup.Domain
{
    public partial class GeoJsonParser
    {
        public class ParsedGeoJson
        {
            public string Id { get; set; }
            public IDictionary<string, string> Properties { get; set; }
            public float[][] Geometry { get; set; }
        }
       
    }
}
