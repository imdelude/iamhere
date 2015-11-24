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

            //Add the credentials
            AppendStringIfNotEmpty(builder, "app_code", request.ApplicationCode);
            AppendStringIfNotEmpty(builder, "app_id", request.ApplicationId);

            builder.Append($"&gen={request.Generation}");


            AppendStringIfNotEmpty(builder, "city", request.City);
            AppendStringIfNotEmpty(builder, "country", request.Country);
            AppendStringIfNotEmpty(builder, "street", request.Street);
            AppendStringIfNotEmpty(builder, "housenumber", request.HouseNumber);
            AppendStringIfNotEmpty(builder, "postalcode", request.PostalCode);
            AppendStringIfNotEmpty(builder, "county", request.County);
            AppendStringIfNotEmpty(builder, "district", request.District);
            AppendStringIfNotEmpty(builder, "state", request.State);
            AppendStringIfNotEmpty(builder, "locationid", request.LocationId);
            AppendStringIfNotEmpty(builder, "countryfocus", request.CountryFocus);

            //Add pagination parameters
            if (request.MaximumPageSize.HasValue)
            {
                builder.Append($"&maxresults={request.MaximumPageSize}");
            }
            if (request.PageNumber.HasValue)
            {
                builder.Append($"&pageinformation={request.PageNumber}");
            }

            return builder.ToString();
        }

        private void AppendStringIfNotEmpty(StringBuilder builder, string parameterName, string parameterValue)
        {
            if (string.IsNullOrEmpty(parameterName)) return;
            if (string.IsNullOrEmpty(parameterValue)) return;

            builder.Append($"&{parameterName}={parameterValue}");
        }
    }
}
