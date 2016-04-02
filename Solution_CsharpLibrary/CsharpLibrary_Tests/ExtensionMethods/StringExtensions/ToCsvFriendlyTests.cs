using System;
using CsharpLibrary.ExtensionMethods;
using NUnit.Framework;

namespace CsharpLibrary_Tests.ExtensionMethods.StringExtensions
{
    [TestFixture]
    public class ToCsvFriendlyTests
    {
        [Test]
        public void AlreadyClean()
        {
            const string original = "Some text that shouldn't be changed by the ToCsvFriendly method";

            Assert.That(original.ToCsvFriendly().Equals(original, StringComparison.CurrentCulture));
        }

        [Test]
        public void ExcapesDoubleQuotes()
        {
            const string original = "Some text with \"double quotes\" in it.";
            const string expectedResult = "\"Some text with \"\"double quotes\"\" in it.\"";

            Assert.That(original.ToCsvFriendly().Equals(expectedResult, StringComparison.CurrentCulture));
        }

        [Test]
        public void HandlesComma()
        {
            const string original = "This, text, is, comma, separated";
            const string expectedResult = "\"This, text, is, comma, separated\"";

            Assert.That(original.ToCsvFriendly().Equals(expectedResult, StringComparison.CurrentCulture));
        }

        [Test]
        public void HandlesCommasAndQuotes()
        {
            const string comma = "This, text, is, comma, separated";
            const string doubleQuotes = "Some text with \"double quotes\" in it.";
            const string expectedResult = "\"This, text, is, comma, separated\",\"Some text with \"\"double quotes\"\" in it.\"";

            Assert.That((String.Join(",", comma.ToCsvFriendly(), doubleQuotes.ToCsvFriendly())).Equals(expectedResult, StringComparison.CurrentCulture));
        }
    }
}
