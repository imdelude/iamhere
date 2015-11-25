using System.Collections.Generic;

namespace iamhere.Responses.Geocoding.Contract
{
    public interface IGeocodingResponse
    {
        IMetadata Metadata { get; }
        IReadOnlyCollection<IView> Views { get; }
    }
}