using System;
using iamhere.Responses.Geocoding.Contract;

namespace iamhere.Responses.Geocoding.Raw
{
    public class MetaInfo : IMetadata
    {
        public DateTime TimeStamp { get; set; }
        public int? NextPageInformation { get; set; }
        public int? PreviousPageInformation { get; set; }

        public int? PreviousPage => PreviousPageInformation;
        public int? NextPage => NextPageInformation;
    }
}