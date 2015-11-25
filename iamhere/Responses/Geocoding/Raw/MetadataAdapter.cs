using System;
using iamhere.Responses.Geocoding.Contract;

namespace iamhere.Responses.Geocoding.Raw
{
    public class MetadataAdapter : IMetadata
    {
        private readonly MetaInfo _metainfo;

        public DateTime TimeStamp => _metainfo.Timestamp;
        public int? PreviousPage => _metainfo.PreviousPageInformation;
        public int? NextPage => _metainfo.NextPageInformation;

        public MetadataAdapter(MetaInfo metainfo)
        {
            if (metainfo == null) throw new ArgumentNullException(nameof(metainfo));
            _metainfo = metainfo;
        }
    }
}