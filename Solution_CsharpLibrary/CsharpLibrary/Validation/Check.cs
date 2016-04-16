using System.Text.RegularExpressions;
using CsharpLibrary.RegularExpressions;

namespace CsharpLibrary.Validation
{
    public static class Check
    {
        public static bool IsEmailAddress(string emailAddress)
        {
            if (string.IsNullOrWhiteSpace(emailAddress))
                return false;

            if (emailAddress.Contains(".."))
                return false;

            return Regex.IsMatch(emailAddress, Patterns.EmailAddress);
        }

        public static bool IsHexValue(string hexValue)
        {
            if (string.IsNullOrWhiteSpace(hexValue))
                return false;

            return Regex.IsMatch(hexValue, Patterns.HexValue);
        }
    }
}
