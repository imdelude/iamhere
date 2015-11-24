using System;

namespace iamhere.Requests
{
    public abstract class Request
    {
        public const int LatestGeneration = 9;

        /// <summary>
        /// Used for authentication of the client application. This must be included in every request to the API.
        /// </summary>
        public string ApplicationId { get; }

        /// <summary>
        /// Used for authentication of the client application. This must be included in every request to the API.
        /// </summary>
        public string ApplicationCode { get; }

        /// <summary>
        /// Enables or disables backward incompatible behaviour in the API. Usage of the latest generation is recommended, at the moment that is 9. If generation 0 is given the default behaviour will be used.
        /// </summary>
        /// <seealso cref="https://developer.here.com/rest-apis/documentation/geocoder/topics/key-concepts-schema-evolution.html#api-different-generations"/>
        public int Generation { get; }

        protected Request(string applicationId, string applicationCode, int generation)
        {
            if (applicationId == null) throw new ArgumentNullException(nameof(applicationId));
            if (applicationCode == null) throw new ArgumentNullException(nameof(applicationCode));
            if (generation < 0 || generation > LatestGeneration) throw new ArgumentException("Valid values are 0-9", nameof(generation));
            ApplicationId = applicationId;
            ApplicationCode = applicationCode;
            Generation = generation;
        }
    }
}