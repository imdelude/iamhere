using System;
using iamhere.Requests.Geocoding;

namespace iamhere.test
{
    class Program
    {
        static void Main(string[] args)
        {
            var iamhere = new IAmHere();
            var request = new GeocodingRequest("applicationId", "applicationCode")
            {
                Country = "Sweden",
                PostalCode = "504 64",
                Street = "Vevgatan 6"
            };

            var response = iamhere.GetGeocodes(request);

            Console.WriteLine(response);
        }
    }
}
