using System;

namespace iamhere.Responses.Geocoding.Contract
{
    public interface IMetadata
    {
        DateTime TimeStamp { get; }
        int? PreviousPage { get; }
        int? NextPage { get; }
    }
}