using System.Text.RegularExpressions;

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

            if (Regex.IsMatch(emailAddress, RegularExpressions.Patterns.EmailAddress))
                return true;

            return Regex.IsMatch(emailAddress, RegularExpressions.Patterns.EmailAddressWithIP);
        }
    }
}
