using iamhere.Common;

namespace iamhere.Responses.Geocoding.Raw
{
    public class Location
    {
        public string LocationId { get; set; }
        public string LocationType { get; set; }
        public GeographicalPoint DisplayPosition { get; set; }
        public GeographicalPoint[] NavigationPosition { get; set; }
        public GeographicalBoundingBox MapView { get; set; }
        public Address Address { get; set; }
    }
}