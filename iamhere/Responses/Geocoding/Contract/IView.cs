using System.Collections.Generic;

namespace iamhere.Responses.Geocoding.Contract
{
    public interface IView
    {
        int? ViewId { get; }
        IReadOnlyCollection<IResult> Results { get; } 
    }
}