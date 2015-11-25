namespace iamhere.Responses.Geocoding.Contract
{
    public interface IMatchQuality
    {
        float? Name { get; }
        float? Country { get; }
        float? State { get; }
        float? County { get; }
        float? City { get; }
        float? District { get; }
        float? Subdistrict { get; }
        float?[] Streets { get; }
        float? HouseNumber { get; }
        float? PostalCode { get; }
        float? Building { get; }
    }
}