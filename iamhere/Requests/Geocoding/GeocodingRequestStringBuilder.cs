using System;
using System.Linq;
using System.Text;
using System.Web;
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
            builder.Append($"?app_code={request.ApplicationCode}");
            builder.Append($"&app_id={request.ApplicationId}");

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

            //Add spatial filters
            if (request.BoundingBox != null)
            {
                AppendStringIfNotEmpty(builder, "bbox", request.BoundingBox.ToString());
            }
            if (request.Proximity != null)
            {
                AppendStringIfNotEmpty(builder, "prox", request.Proximity.ToString());
            }
             
            AppendStringIfNotEmpty(builder, "politicalview", request.PoliticalView.ToCamelCaseString());

            //Add response attributes
            AppendStringIfNotEmpty(builder, "addressattributes", BuildCommaSeparatedString(request.AddressAttributes, BuildAddressAttributeString));
            AppendStringIfNotEmpty(builder, "locationattributes", BuildCommaSeparatedString(request.LocationAttributes, BuildLocationAttributeString));
            AppendStringIfNotEmpty(builder, "responseattributes", BuildCommaSeparatedString(request.ResponseAttributes, BuildResponseAttributeString));


            return HttpUtility.UrlEncode(builder.ToString());
        }

        private string BuildCommaSeparatedString<T>(T[] values, Func<T, string> valueToStringFunc)
        {
            return string.Join(",", values.Select(valueToStringFunc));
        }

        private string BuildAddressAttributeString(AddressAttribute addressAttribute)
        {
            switch (addressAttribute)
            {
                case AddressAttribute.City:
                    return "city";
                case AddressAttribute.Country:
                    return "country";
                case AddressAttribute.County:
                    return "county";
                case AddressAttribute.District:
                    return "district";
                case AddressAttribute.HouseNumber:
                    return "houseNumber";
                case AddressAttribute.PostalCode:
                    return "postalCode";
                case AddressAttribute.State:
                    return "state";
                case AddressAttribute.Street:
                    return "street";
                case AddressAttribute.Subdistrict:
                    return "subdistrict";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private string BuildLocationAttributeString(LocationAttribute locationAttribute)
        {
            switch (locationAttribute)
            {
                case LocationAttribute.Address:
                    return "address";
                case LocationAttribute.MapView:
                    return "mapView";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private string BuildResponseAttributeString(ResponseAttribute responseAttribute)
        {
            switch (responseAttribute)
            {
                case ResponseAttribute.MatchCode:
                    return "matchCode";
                case ResponseAttribute.MatchQuality:
                    return "matchQuality";
                case ResponseAttribute.MatchType:
                    return "matchType";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void AppendStringIfNotEmpty(StringBuilder builder, string parameterName, string parameterValue)
        {
            if (string.IsNullOrEmpty(parameterName)) return;
            if (string.IsNullOrEmpty(parameterValue)) return;

            builder.Append($"&{parameterName}={parameterValue}");
        }
    }
}