using System;
using iamhere.Extensions;
using iamhere.Responses.Geocoding.Contract;

namespace iamhere.Responses.Geocoding.Raw
{
    public class ResultAdapter : IResult
    {
        private readonly Result _result;

        public float? Relevance => _result.Relevance;
        public MatchLevel MatchLevel => _result.MatchLevel.ParseToEnum<MatchLevel>(true);
        public MatchCode MatchCode => _result.MatchCode.ParseToEnum<MatchCode>(true);
        public MatchType MatchType => _result.MatchType.ParseToEnum<MatchType>(true);

        private IMatchQuality _matchQuality;
        public IMatchQuality MatchQuality => _matchQuality ?? (_matchQuality = new MatchQualityAdapter(_result.MatchQuality));

        private ILocation _location;
        public ILocation Location => _location ?? (_location = new LocationAdapter(_result.Location));

        public ResultAdapter(Result result)
        {
            if (result == null) throw new ArgumentNullException(nameof(result));
            _result = result;
        }
    }
}