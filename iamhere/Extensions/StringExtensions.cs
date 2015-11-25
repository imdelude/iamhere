using System;

namespace iamhere.Extensions
{
    public static class StringExtensions
    {
        public static T ParseToEnum<T>(this string value, bool ignoreCase)
        {
            return (T)Enum.Parse(typeof (T), value, ignoreCase);
        }
    }
}