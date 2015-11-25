namespace iamhere.Responses.Geocoding.Raw
{
    public class MatchQuality
    {
        public float? Name { get; set; }
        public float? Country { get; set; }
        public float? State { get; set; }
        public float? County { get; set; }
        public float? City { get; set; }
        public float? District { get; set; }
        public float? Subdistrict { get; set; }
        public float?[] Street { get; set; }
        public float? HouseNumber { get; set; }
        public float? PostalCode { get; set; }
        public float? Building { get; set; }
    }
}