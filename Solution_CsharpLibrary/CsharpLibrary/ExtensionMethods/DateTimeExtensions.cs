using System;

namespace CsharpLibrary.ExtensionMethods
{
    public static class DateTimeExtensions
    {
        public static double ToJavaScriptMilliseconds(this DateTime utcDateTime)
        {
            return utcDateTime
                .ToUniversalTime()
                .Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc))
                .TotalMilliseconds;
        }
    }
}
