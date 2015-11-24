using System;
using System.Net.Http;
using System.Threading.Tasks;
using iamhere.Common;
using iamhere.Requests;
using iamhere.Requests.Geocoding;

namespace iamhere
{
    // ReSharper disable once InconsistentNaming
    public class IAmHere
    {
        private const string BaseUrl = "http://geocoder.cit.api.here.com";
        private const string CurrentVersion = "6.2";
        private const ResponseFormat ResponseFormat = Common.ResponseFormat.Json;

        private readonly IRequestStringBuilder<GeocodingRequest> _geocodingRequestStringBuilder;

        public IAmHere() : this(new GeocodingRequestStringBuilder(BaseUrl, CurrentVersion, ResponseFormat)) { }

        public IAmHere(IRequestStringBuilder<GeocodingRequest> geocodingRequestStringBuilder)
        {
            if (geocodingRequestStringBuilder == null) throw new ArgumentNullException(nameof(geocodingRequestStringBuilder));
            _geocodingRequestStringBuilder = geocodingRequestStringBuilder;
        }

        //The return object will be our response structure later on, the string is just for now
        public string GetGeocodes(GeocodingRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            using (var client = new HttpClient())
            {
                var requestString = _geocodingRequestStringBuilder.Build(request);

                var response = client.GetAsync(requestString).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseString = response.Content.ReadAsStringAsync().Result;

                    return responseString; // This is where we would parse into our response data structure
                }

                //Throw an exception here because the status code was not successful?
                return string.Empty;
            }
        }

        public async Task<string> GetGeocodeAsync(GeocodingRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            using (var client = new HttpClient())
            {
                var requestString = _geocodingRequestStringBuilder.Build(request);

                var response = await client.GetAsync(requestString);
                var body = await response.Content.ReadAsStringAsync();

                return body;
            }
        }
    }
}