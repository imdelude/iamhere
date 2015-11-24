namespace iamhere.Common
{
    /// <summary>
    /// Represents a rectangular area in a geographical coordinate system.
    /// </summary>
    public struct GeographicalBoundingBox
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
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public override string ToString()
        {
            return $"{TopLeft};{BottomRight}";
        }
    }
}