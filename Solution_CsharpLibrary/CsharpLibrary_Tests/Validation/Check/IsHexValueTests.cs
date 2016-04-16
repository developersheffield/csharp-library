using NUnit.Framework;

namespace CsharpLibrary_Tests.Validation.Check
{
    [TestFixture]
    public class IsHexValueTests
    {
        [TestCase("#f2f2da", ExpectedResult = true)]
        [TestCase("#09fefd", ExpectedResult = true)]
        public bool ValidHexValue_FullWithHash(string hexValue)
        {
            return CsharpLibrary.Validation.Check.IsHexValue(hexValue);
        }

        [TestCase("#f2f", ExpectedResult = true)]
        [TestCase("#09f", ExpectedResult = true)]
        public bool ValidHexValue_PartialWithHash(string hexValue)
        {
            return CsharpLibrary.Validation.Check.IsHexValue(hexValue);
        }

        [TestCase("f2f2da", ExpectedResult = true)]
        [TestCase("09fefd", ExpectedResult = true)]
        public bool ValidHexValue_FullWithoutHash(string hexValue)
        {
            return CsharpLibrary.Validation.Check.IsHexValue(hexValue);
        }

        [TestCase("f2f", ExpectedResult = true)]
        [TestCase("09f", ExpectedResult = true)]
        public bool ValidHexValue_PartialWithoutHash(string hexValue)
        {
            return CsharpLibrary.Validation.Check.IsHexValue(hexValue);
        }

        [TestCase("##ffffff", ExpectedResult = false)]
        [TestCase(" #fff", ExpectedResult = false)]
        [TestCase("#fffffg", ExpectedResult = false)]
        [TestCase("#ff", ExpectedResult = false)]
        public bool InValidHexValue(string hexValue)
        {
            return CsharpLibrary.Validation.Check.IsHexValue(hexValue);
        }
    }
}
