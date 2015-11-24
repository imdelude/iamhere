using System;

namespace iamhere.Common
{
    /// <summary>
    /// Represents a rectangular area in a geographical coordinate system.
    /// </summary>
    public class GeographicalBoundingBox
    {
        /// <summary>
        /// Top-left corner of the rectangular area.
        /// </summary>
        public GeographicalPoint TopLeft { get; }

        /// <summary>
        /// Bottom-right corner of the rectangular area.
        /// </summary>
        public GeographicalPoint BottomRight { get; }

        public GeographicalBoundingBox(GeographicalPoint topLeft, GeographicalPoint bottomRight)
        {
            if (topLeft == null) throw new ArgumentNullException(nameof(topLeft));
            if (bottomRight == null) throw new ArgumentNullException(nameof(bottomRight));
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public override string ToString()
        {
            return $"{TopLeft};{BottomRight}";
        }
    }
}