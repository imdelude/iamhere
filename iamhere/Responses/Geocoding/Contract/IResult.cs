namespace iamhere.Responses.Geocoding.Contract
{
    public interface IResult
    {
        float? Relevance { get; }
        string MatchLevel { get; } //Enum
        IMatchQuality MatchQuality { get; }
        ILocation Location { get; }
    }
}