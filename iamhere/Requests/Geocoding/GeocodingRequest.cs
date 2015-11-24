using iamhere.Common;

namespace iamhere.Requests.Geocoding
{
    /// <summary>
    /// Represents the request that will be made to the Geocode resource.
    /// </summary>
    public class GeocodingRequest : Request
    {
        /// <summary>
        /// List of address elements that will be present in the response data.
        /// </summary>
        public AddressAttribute[] AddressAttributes { get; set; } =
        {
            AddressAttribute.Country, AddressAttribute.State, AddressAttribute.County,
            AddressAttribute.City, AddressAttribute.District, AddressAttribute.Subdistrict,
            AddressAttribute.Street, AddressAttribute.HouseNumber, AddressAttribute.PostalCode,
            AddressAttribute.AdditionalData
        };

        /// <summary>
        /// A type of spatial filter that limits the search for any other attributes in the request.
        /// </summary>
        public GeographicalBoundingBox BoundingBox { get; set; }

        /// <summary>
        /// The city. Uses fuzzy matching.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Specifies the country using the country code (ISO 3166-1-alpha-3) or the country name. This is a strict filter; meaining that results are restricted to the specified country.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Results from the specified country (ISO 3166-1-alpha-3) are preferred. This is a soft filter, if both this and Country are specified the Country filter will takes precedence.
        /// </summary>
        public string CountryFocus { get; set; }

        /// <summary>
        /// Second subdivision below the country. Depending on the admin hierarchy in a country this level might not be applicable. Uses fuzzy matching.
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// Subdivision level below the city. Depending on the admin hierarchy in a country this level might not be applicable. Uses fuzzy matching.
        /// </summary>
        public string District { get; set; }

        /// <summary>
        /// The house number or house name. Uses exact matching.
        /// </summary>
        public string HouseNumber { get; set; }

        /// <summary>
        /// List of location elements that will be present in the response data.
        /// </summary>
        public LocationAttribute[] LocationAttributes { get; set; } =
        {
            LocationAttribute.Address, LocationAttribute.MapView, LocationAttribute.AdditionalData
        };

        /// <summary>
        /// A key uniquely identifying a physical location. Each record in a geocode response contains a location id.
        /// </summary>
        public string LocationId { get; set; }

        /// <summary>
        /// The maximum number of results in one page result.
        /// </summary>
        public int? MaximumPageSize { get; set; }

        /// <summary>
        /// Which result page that should be retrieved. This is only relevant if MaximumPageSize was specified in the previous request and if the response was paginated.
        /// </summary>
        public int? PageNumber { get; set; }

        /// <summary>
        /// Specifies the political view that will be used to show territories through the point of view of the given country.
        /// </summary>
        public PoliticalView PoliticalView { get; set; } = PoliticalView.Default;

        /// <summary>
        /// Postal code as defined by the government of the country. 
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// A type of spatical filter that limits the search for any other attributes in the request.
        /// </summary>
        public GeographicalCircularArea Proximity { get; set; } 

        /// <summary>
        /// List of response elements that will be present in the response data.
        /// </summary>
        public ResponseAttribute[] ResponseAttributes { get; set; } =
        {
            ResponseAttribute.MatchQuality, ResponseAttribute.MatchType
        };

        /// <summary>
        /// First subdivision below the country. Supports full or abbreviated notation. Uses exact matching.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The street name can include suite, apt and floor information. Uses fuzzy matching.
        /// </summary>
        public string Street { get; set; }


        public GeocodingRequest(string applicationId, string applicationCode, int generation) : base(applicationId, applicationCode, generation)
        {
        }
    }
}