using System.Collections.Generic;
using GeoLocalNet.CountryLookup.Domain;

namespace GeoLocalNet.CountryLookup.Abstractions
{
    public interface IGeoJsonParser
    {
        IEnumerable<GeoJsonParser.ParsedGeoJson> Convert(dynamic json);
        IEnumerable<GeoJsonParser.ParsedGeoJson> Convert(string json);
    }
}