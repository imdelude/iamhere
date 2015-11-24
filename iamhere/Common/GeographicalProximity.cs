using System;

namespace iamhere.Common
{
    /// <summary>
    /// Represents a circular area 
    /// </summary>
    public class GeographicalCircularArea
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
            if (center == null) throw new ArgumentNullException(nameof(center));
            Center = center;
            Radius = radius;
        }

        public override string ToString()
        {
            return $"{Center.Latitude},{Center.Longitude},{Radius}";
        }
    }
}