namespace iamhere.Common
{
    public enum ResponseFormat
    {
        Json,
        Xml
    }

    public static class ResponseFormatExtensions
    {
        public static string ToFriendlyString(this ResponseFormat responseFormat)
        {
            if (responseFormat == ResponseFormat.Json)
            {
                return "json";
            }
            if (responseFormat == ResponseFormat.Xml)
            {
                return "xml";
            }

            return string.Empty;
        }
    }
}