using System;
using System.Text;
using iamhere.Common;

namespace iamhere.Requests.Geocoding
{
    public class GeocodingRequestStringBuilder : IRequestStringBuilder<GeocodingRequest>
    {
        public const string GeocodingResourceEndpoint = "geocode";

        private readonly string _baseUrl;
        private readonly string _version;
        private readonly ResponseFormat _responseFormat;

        private string BaseUrl => $"{_baseUrl}/{_version}/{GeocodingResourceEndpoint}.{_responseFormat.ToFriendlyString()}";

        public GeocodingRequestStringBuilder(string baseUrl, string version, ResponseFormat responseFormat)
        {
            if (baseUrl == null) throw new ArgumentNullException(nameof(baseUrl));
            if (version == null) throw new ArgumentNullException(nameof(version));
            _baseUrl = baseUrl;
            _version = version;
            _responseFormat = responseFormat;
        }

        public string Build(GeocodingRequest request)
        {
            //Verify the input here?

            var builder = new StringBuilder();
            builder.Append(BaseUrl);


            return builder.ToString();
        }

    }
}

//der("http://geocoder.api.here.com/6.2/geocode");