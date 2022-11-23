using GeoLocalNet.CountryLookup;
using GeoLocalNet.CountryLookup.Domain;

namespace GeoLocalNet.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var rl = new ReverseLookup();
            var a = rl.Lookup((float)38.7573981, (float)-9.2587453, new RegionType[] { RegionType.Country });
        }
    }
}