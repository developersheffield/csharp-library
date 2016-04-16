namespace CsharpLibrary.RegularExpressions
{
    public static class Patterns
    {
        public static string IpAddress = @"((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)";

        #region Email address segment patterns

        // Characters allowed before the @
        private const string emailAddressAllowedBeforeAt = @"[a-zA-Z0-9""_+\-]";
        
        // As above but also with . (allowed but not at the start or end)
        private const string emailAddressAllowedBeforeAtPlusDot = @"[a-zA-Z0-9""_\+\-\.]";

        // Characters allowed after the @
        private const string emailAddressAllowedAfterAt = @"[a-zA-Z0-9]";

        // As above but including . and - (allowed but not at the start or end)
        private const string emailAddressAllowedAfterAtPlusDot = @"[a-zA-Z0-9\-\.]";

        // Characters allowed as part of the Top Level Domain
        private const string emailAddressAllowedTLD = @"[a-zA-Z]";

        // As above but including . (. is allowed but not at the start or end)
        private const string emailAddressAllowedTLDPlusDot = @"[a-zA-Z\.]";

        #endregion

        public static string EmailAddress = string.Format(@"^{0}{1}*{0}@({2}{3}*{2}\.{4}{5}*{4}|(\[?){6}(\]?))$",
            emailAddressAllowedBeforeAt,
            emailAddressAllowedBeforeAtPlusDot,
            emailAddressAllowedAfterAt,
            emailAddressAllowedAfterAtPlusDot,
            emailAddressAllowedTLD,
            emailAddressAllowedTLDPlusDot,
            IpAddress);

        /// <summary>
        /// Valid Hex value with or without # prefix and full 6 digits or partial 3 digits
        /// </summary>
        public static string HexValue = @"^#?([a-fA-Z0-9]{6}|[a-fA-Z0-9]{3})$";
    }
}
