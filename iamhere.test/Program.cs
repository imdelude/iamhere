using System;
using System.Configuration;
using iamhere.Requests;
using iamhere.Requests.Geocoding;

namespace iamhere.test
{
    class Program
    {
        static void Main(string[] args)
        {
            var iamhere = new IAmHere();
            var request = new GeocodingRequest(ConfigurationManager.AppSettings["ApplicationId"], ConfigurationManager.AppSettings["ApplicationCode"])
            {
                Country = "Sweden",
                PostalCode = "504 64",
                Street = "Vevgatan 6",
                ResponseAttributes = new []{ResponseAttribute.MatchCode, ResponseAttribute.MatchQuality, ResponseAttribute.MatchType, }
            };

            var response = iamhere.GetGeocodes(request);

            Console.WriteLine(response);
        }
    }
}
