using iamhere.Common;
using iamhere.Responses.Geocoding.Raw;

namespace iamhere.Responses.Geocoding.Contract
{
    public interface ILocation
    {
        string LocationIdentifier { get; }
        LocationType LocationType { get; }
        GeographicalPoint DisplayPosition { get; }
        GeographicalPoint[] NavigationPositions { get; }
        GeographicalBoundingBox MapView { get; }
        IAddress Address { get; }
    }
}