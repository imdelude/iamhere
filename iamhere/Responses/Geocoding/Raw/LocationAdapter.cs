using System;
using iamhere.Common;
using iamhere.Extensions;
using iamhere.Responses.Geocoding.Contract;

namespace iamhere.Responses.Geocoding.Raw
{
    public class LocationAdapter : ILocation
    {
        private readonly Location _location;

        private LocationType? _locationType;
        public LocationType LocationType
        {
            get
            {
                if (_locationType == null)
                {
                    _locationType = _location.LocationType.ParseToEnum<LocationType>(true);
                }

                return _locationType.Value;
            }
        }

        public string LocationIdentifier => _location.LocationId;
        public GeographicalPoint DisplayPosition => _location.DisplayPosition;
        public GeographicalPoint[] NavigationPositions => _location.NavigationPosition;
        public GeographicalBoundingBox MapView => _location.MapView;
        public IAddress Address => _location.Address;

        public LocationAdapter(Location location)
        {
            if (location == null) throw new ArgumentNullException(nameof(location));
            _location = location;
        }
    }
}