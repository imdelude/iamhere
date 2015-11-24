namespace iamhere.Common
{
    /// <summary>
    /// Represents a geographical position.
    /// </summary>
    public class GeographicalPoint
    {
        public float Latitude { get; }
        public float Longitude { get; }

        public GeographicalPoint(float latitude, float longitude)
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