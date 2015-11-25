using System;
using iamhere.Common;

namespace iamhere.Responses
{
    /// <summary>
    /// Class used to represent a HERE-response
    /// </summary>
    public class HereResponse : IHereResponse
    {
        public Response Response { get; set; }
    }

    /// <summary>
    /// Classes used to represent the different parts/attributes of a HERE-response
    /// </summary>
    public class Response
    {
        public Metainfo MetaInfo { get; set; }
        public View[] View { get; set; }
    }

    public class Metainfo
    {
        public DateTime Timestamp { get; set; }
        public int? NextPageInformation { get; set; }
        public int? PreviousPageInformation { get; set; }
    }


    public class View
    {
        public int? ViewId { get; set; }
        public Result[] Result { get; set; }
    }

    public class Result
    {
        public float? Relevance { get; set; }
        public string MatchLevel { get; set; }
        public Matchquality MatchQuality { get; set; }
        public Location Location { get; set; }
    }

    public class Matchquality
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

    public class Location
    {
        public string LocationId { get; set; }
        public string LocationType { get; set; }
        public GeographicalPoint DisplayPosition { get; set; }
        public GeographicalPoint[] NavigationPosition { get; set; }
        public GeographicalBoundingBox MapView { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string Label { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public AdditionalData[] AdditionalData { get; set; }
    }

    public class AdditionalData
    {
        public string Value { get; set; }
        public string Key { get; set; }
    }   
}
