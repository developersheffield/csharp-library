using CsharpLibrary.ExtensionMethods;
using NUnit.Framework;

namespace CsharpLibrary_Tests.ExtensionMethods.IntExtensions
{
    [TestFixture]
    public class IsOddTests
    {
        [TestCase(1, ExpectedResult = true)]
        [TestCase(2, ExpectedResult = false)]
        [TestCase(3, ExpectedResult = true)]
        [TestCase(4, ExpectedResult = false)]
        [TestCase(103, ExpectedResult = true)]
        [TestCase(108, ExpectedResult = false)]
        [TestCase(1531, ExpectedResult = true)]
        [TestCase(1600, ExpectedResult = false)]
        public bool IsOdd(int integer)
        {
            return integer.IsOdd();
        }
    }
}
