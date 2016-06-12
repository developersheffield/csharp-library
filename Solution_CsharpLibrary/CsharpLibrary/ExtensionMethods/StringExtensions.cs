using System;

namespace CsharpLibrary.ExtensionMethods
{
    public static class StringExtensions
    {
        /// <summary>
        /// Sanitises a string so it is suitable for use as a "cell" is a CSV file
        /// </summary>
        /// <param name="text">Original string</param>
        /// <returns>Sanitised string</returns>
        public static string ToCsvFriendly(this string text)
        {
            if (!(text.Contains(",") || text.Contains("\"")))
                return text;

            // Replace quotes with double quotes to escape quotes and wrap all text in quotes to avoid comma's breaking the text
            return $"\"{text.Replace("\"", "\"\"")}\"";
        }

        public static string[] SplitByString(this string text, string splitBy)
        {
            return text.Split(new[] { splitBy }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
