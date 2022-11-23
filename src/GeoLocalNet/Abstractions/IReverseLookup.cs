using GeoLocalNet.CountryLookup.Domain;

namespace GeoLocalNet.CountryLookup.Abstractions
{
    public interface IReverseLookup
    {
        Region[] Regions { get; }

        Region Lookup(float lat, float lng, params RegionType[] types);
    }
}