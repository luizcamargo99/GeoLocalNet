using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using GeoLocalNet.CountryLookup.Abstractions;

namespace GeoLocalNet.CountryLookup.Services
{
    public class FileLoader : IFileLoader
    {
        public IEnumerable<string> LoadFile()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var t = assembly.GetManifestResourceNames();
            using (var stream = assembly.GetManifestResourceStream("GeoLocalNet.region-list.json"))
            using (var reader = new StreamReader(stream ?? throw new InvalidOperationException()))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }
    }
}
