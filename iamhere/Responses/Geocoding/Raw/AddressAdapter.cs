using System;
using iamhere.Responses.Geocoding.Contract;

namespace iamhere.Responses.Geocoding.Raw
{
    public class AddressAdapter : IAddress
    {
        private readonly Address _address;

        public string Label => _address.Label;
        public string Country => _address.Country;
        public string State => _address.State;
        public string County => _address.County;
        public string City => _address.City;
        public string PostalCode => _address.PostalCode;
        public string Street => _address.Street;
        public string HouseNumber => _address.HouseNumber;

        internal AddressAdapter(Address address)
        {
            if (address == null) throw new ArgumentNullException(nameof(address));
            _address = address;
        }
    }
}