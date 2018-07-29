namespace CsharpLibrary.Html
{
    public static class Character
    {
        public const string Ampersand = "&amp;"; // &

        public const string Ellipsis = "&hellip;"; // ...
		public const string Apostrophe = "&apos;"; // '

        // https://en.wikipedia.org/wiki/Dash#En_dash_versus_em_dash
        public const string EmDash = "&mdash;"; // - (Break between 2 parts of a sentence)
        public const string EnDash = "&ndash;"; // - (to/range)
		
		public const string NonBreakingHyphen = "&#8209;"; // Hyphen that doesn't allow word to break at end of line

        public const string Copyright = "&copy;"; // (c)
        public const string Trademark = "&trade;"; // TM

        public const string FractionQuarter = "&frac14;"; // 1/4
        public const string FractionHalf = "&frac12;"; // 1/2
        public const string FractionThreeQuarters = "&frac34;"; // 3/4
        public const string MathsDivide = "&divide;"; // Maths divide
        public const string MathsMultiple = "&times;"; // Maths multiply
        public const string Degree = "&deg;"; // e.g. Temperature or Angle

        public const string LeftDoubleQuote = "&ldquo;"; // " (left)
        public const string RightDoubleQuote = "&rdquo;"; // " (right)
        public const string LeftSingleQuote = "&lsquo;"; // ' (left)
        public const string RightSingleQuote = "&rsquo;"; // ' (right) or apostrophe
    }
}
