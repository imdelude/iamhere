namespace iamhere.Common
{
    /// <summary>
    /// Represents a geographical position.
    /// </summary>
    public struct GeographicalPoint
    {
        public float Latitude { get; }
        public float Longitude { get; }

        public GeographicalPoint(int latitude, int longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public override string ToString()
        {
            return $"{Latitude},{Longitude}";
        }
    }
}