namespace iamhere.Responses.Geocoding.Raw
{
    public class Result
    {
        public float? Relevance { get; set; }
        public string MatchLevel { get; set; }
        public MatchQuality MatchQuality { get; set; }
        public Location Location { get; set; }
    }
}