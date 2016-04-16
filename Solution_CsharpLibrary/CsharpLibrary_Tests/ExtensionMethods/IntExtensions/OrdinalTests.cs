using CsharpLibrary.ExtensionMethods;
using NUnit.Framework;

namespace CsharpLibrary_Tests.ExtensionMethods.IntExtensions
{
    [TestFixture]
    public class OrdinalTests
    {
        [TestCase(1, ExpectedResult = "st")]
        [TestCase(2, ExpectedResult = "nd")]
        [TestCase(3, ExpectedResult = "rd")]
        [TestCase(4, ExpectedResult = "th")]
        [TestCase(7, ExpectedResult = "th")]
        [TestCase(11, ExpectedResult = "th")]
        [TestCase(12, ExpectedResult = "th")]
        [TestCase(13, ExpectedResult = "th")]
        [TestCase(24, ExpectedResult = "th")]
        [TestCase(45, ExpectedResult = "th")]
        [TestCase(61, ExpectedResult = "st")]
        [TestCase(82, ExpectedResult = "nd")]
        [TestCase(111, ExpectedResult = "th")]
        [TestCase(1096, ExpectedResult = "th")]
        [TestCase(2000, ExpectedResult = "th")]
        public string Ordinal(int integer)
        {
            return integer.Ordinal();
        }
    }
}
