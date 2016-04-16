using CsharpLibrary.ExtensionMethods;
using NUnit.Framework;

namespace CsharpLibrary_Tests.ExtensionMethods.IntExtensions
{
    [TestFixture]
    public class NegateTests
    {
        [TestCase(-2, ExpectedResult = 2)]
        [TestCase(-1, ExpectedResult = 1)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = -1)]
        [TestCase(2, ExpectedResult = -2)]
        public int Negate(int integer)
        {
            return integer.Negate();
        }
    }
}
