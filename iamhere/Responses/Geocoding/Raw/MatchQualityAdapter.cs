using System;
using iamhere.Responses.Geocoding.Contract;

namespace iamhere.Responses.Geocoding.Raw
{
    public class MatchQualityAdapter : IMatchQuality
    {
        private readonly MatchQuality _matchQuality;

        public float? Name => _matchQuality.Name;
        public float? Country => _matchQuality.Country;
        public float? State => _matchQuality.State;
        public float? County => _matchQuality.County;
        public float? City => _matchQuality.City;
        public float? District => _matchQuality.District;
        public float? Subdistrict => _matchQuality.Subdistrict;
        public float?[] Streets => _matchQuality.Street;
        public float? HouseNumber => _matchQuality.HouseNumber;
        public float? PostalCode => _matchQuality.PostalCode;
        public float? Building => _matchQuality.Building;

        public MatchQualityAdapter(MatchQuality matchQuality)
        {
            if (matchQuality == null) throw new ArgumentNullException(nameof(matchQuality));
            _matchQuality = matchQuality;
        }
    }
}