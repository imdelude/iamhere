using System;
using System.Net.Http;
using System.Threading.Tasks;
using iamhere.Common;
using iamhere.Requests;
using iamhere.Requests.Geocoding;
using iamhere.Responses.Geocoding.Contract;
using iamhere.Responses.Geocoding.Raw;
using Newtonsoft.Json;

namespace iamhere
{
    // ReSharper disable once InconsistentNaming
    public class IAmHere
    {
        private const string BaseUrl = "http://geocoder.cit.api.here.com";
        private const string CurrentVersion = "6.2";
        private const ResponseFormat ResponseFormat = Common.ResponseFormat.Json;

        private IRequestStringBuilder<GeocodingRequest> _geocodingRequestStringBuilder;
        public IRequestStringBuilder<GeocodingRequest> GeocodingRequestStringBuilder
        {
            get
            {
                return _geocodingRequestStringBuilder ??
                       (_geocodingRequestStringBuilder =
                           new GeocodingRequestStringBuilder(BaseUrl, CurrentVersion, ResponseFormat));
            }
            set
            {
                // ReSharper disable once NotResolvedInText
                if (value == null) throw new ArgumentNullException("GeocodingRequestStringBuilder");
                _geocodingRequestStringBuilder = value;
            }
        }

        //The return object will be our response structure later on, the string is just for now
        public IGeocodingResponse GetGeocodes(GeocodingRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            using (var client = new HttpClient())
            {
                var requestString = GeocodingRequestStringBuilder.Build(request);

                var response = client.GetAsync(requestString).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseString = response.Content.ReadAsStringAsync().Result;
                    var hereResponse = JsonConvert.DeserializeObject<HereResponse>(responseString);

                    return new GeocodingResponseAdapter(hereResponse.Response); // This is where we would parse into our response data structure
                }

                //Throw an exception here because the status code was not successful?
                throw new Exception("Failed to retrieve Geocoding-response");
            }
        }

        public async Task<string> GetGeocodeAsync(GeocodingRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            using (var client = new HttpClient())
            {
                var requestString = GeocodingRequestStringBuilder.Build(request);

                var response = await client.GetAsync(requestString);
                var body = await response.Content.ReadAsStringAsync();

                //How should we handle http codes that indiciate failure?

                //This is where we will parse into our response data structure

                return body;
            }
        }
    }
}