using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Globalization;

namespace Ticketing_Project.Classes
{
    public class Places
    {
        public List<Location> GetLocationList()
        {
            List<Location> data;
            using (var stream = new StreamReader(@$"{Environment.CurrentDirectory}\\..\..\\..\\Resources\\world_cities_geoname.csv"))
            {
                using (var reader = new CsvReader(stream, CultureInfo.InvariantCulture))
                {
                    data = reader.GetRecords<Location>().ToList();
                }
            }

            return data;
        }
    }

    public class Location
    {
        [Name("name_en")]
        public string City { get; set; }
        [Name("country")]
        public string Country { get; set; }
        [Name("country_code")]
        public string Country_Code { get; set; }
        [Name("latitude")]
        public double Latitude { get; set; }
        [Name("longitude")]
        public double Longitude { get; set; }

    }
}
