using iamhere.Responses.Geocoding.Raw;

namespace iamhere.Responses.Geocoding.Contract
{
    public interface IResult
    {
        float? Relevance { get; }
        MatchLevel MatchLevel { get; }
        MatchCode MatchCode { get; }
        MatchType MatchType { get; }
        IMatchQuality MatchQuality { get; }
        ILocation Location { get; }
    }
}