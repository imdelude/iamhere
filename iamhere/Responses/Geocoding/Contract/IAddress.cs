namespace iamhere.Responses.Geocoding.Contract
{
    public interface IAddress
    {
        string Label { get; }
        string Country { get; }
        string State { get; }
        string County { get; }
        string City { get; }
        string PostalCode { get; }
        string Street { get; }
        string HouseNumber { get; }
    }
}