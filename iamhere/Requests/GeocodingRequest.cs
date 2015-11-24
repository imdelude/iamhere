namespace iamhere.Requests
{
    /// <summary>
    /// Represents the request that will be made to the Geocode resource.
    /// </summary>
    public class GeocodingRequest : Request
    {
        /// <summary>
        /// Specifies the country using the country code (ISO 3166-1-alpha-3) or the country name. This is a strict filter; meaining that results are restricted to the specified country.
        /// </summary>
        public string Country { get; set; }

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