using iamhere.Common;

namespace iamhere.Responses.Geocoding.Contract
{
    public interface ILocation
    {
        string LocationIdentifier { get; }
        string LocationType { get; } //Enum
        GeographicalPoint DisplayPosition { get; }
        GeographicalPoint[] NavigationPositions { get; }
        GeographicalBoundingBox MapView { get; }
        IAddress Address { get; }
    }
}