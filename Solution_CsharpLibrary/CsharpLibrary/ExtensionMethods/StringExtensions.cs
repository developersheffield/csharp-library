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

        public static string AfterFirstInstanceOf(this string text, string marker)
        {
            return text.IndexOf(marker, StringComparison.Ordinal) == -1 
                ? text 
                : text.Substring(text.IndexOf(marker, StringComparison.Ordinal) + marker.Length);
        }

        public static string MaxLength(this string text, int maxLength, string suffix = "")
        {
            return text.Length > maxLength ? text.Substring(0, maxLength) + suffix : text;
        }

        public static string Abbreviate(this string text, int numberOfWords, string suffix = "")
        {
            int words = numberOfWords;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    words--;
                }

                if (words == 0)
                {
                    return text.Substring(0, i) + suffix;
                }

                if (i == text.Length - 1)
                {
                    return text;
                }
            }

            return text;
        }
    }
}
