using System.Collections.Generic;

namespace GeoLocalNet.CountryLookup.Abstractions
{
    public interface IFileLoader
    {
        IEnumerable<string> LoadFile();
    }
}