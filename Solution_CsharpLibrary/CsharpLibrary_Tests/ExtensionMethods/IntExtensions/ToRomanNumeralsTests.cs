using CsharpLibrary.ExtensionMethods;
using NUnit.Framework;

namespace CsharpLibrary_Tests.ExtensionMethods.IntExtensions
{
    [TestFixture]
    public class ToRomanNumeralsTests
    {
        [TestCase(1, ExpectedResult = "I")]
        [TestCase(64, ExpectedResult = "LXIV")]
        [TestCase(226, ExpectedResult = "CCXXVI")]
        [TestCase(900, ExpectedResult = "CM")]
        [TestCase(998, ExpectedResult = "CMXCVIII")]
        [TestCase(1712, ExpectedResult = "MDCCXII")]
        public string ToRomanNumerals(int integer)
        {
            return integer.ToRomanNumerals();
        }
    }
}
