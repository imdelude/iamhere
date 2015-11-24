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
        /// Specifies the political view that will be used to show territories through the point of view of the given country.
        /// </summary>
        public PoliticalView PoliticalView { get; set; } = PoliticalView.Default;

        public GeocodingRequest(string applicationId, string applicationCode, int generation) : base(applicationId, applicationCode, generation)
        {
        }
    }
}