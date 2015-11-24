namespace iamhere.Requests
{
    /// <summary>
    /// Represents an address element which will be present in the response data.
    /// </summary>
    public enum AddressAttribute
    {
        Country = 0,
        State = 1,
        County = 2,
        City = 3,
        District = 4,
        Subdistrict = 5,
        Street = 6,
        HouseNumber = 7,
        PostalCode = 8,
        AddressLines = 9,
        AdditionalData = 10
    }
}