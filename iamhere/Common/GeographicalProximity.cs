namespace iamhere.Common
{
    /// <summary>
    /// Represents a circular area 
    /// </summary>
    public struct GeographicalCircularArea
    {
        /// <summary>
        /// The center of the circular area
        /// </summary>
        public GeographicalPoint Center { get; }

        /// <summary>
        /// The radius in meters
        /// </summary>
        public int Radius { get; }

        /// <summary>
        /// Creates a new GeographicalCircularArea
        /// </summary>
        /// <param name="center">The center of the circular area.</param>
        /// <param name="radius">The radius of the area, in meters.</param>
        public GeographicalCircularArea(GeographicalPoint center, int radius)
        {
            Center = center;
            Radius = radius;
        }
    }
}