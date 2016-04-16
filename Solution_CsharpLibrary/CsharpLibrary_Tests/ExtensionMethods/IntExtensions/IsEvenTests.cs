using CsharpLibrary.ExtensionMethods;
using NUnit.Framework;

namespace CsharpLibrary_Tests.ExtensionMethods.IntExtensions
{
    [TestFixture]
    public class IsEvenTests
    {
        [TestCase(1, ExpectedResult = false)]
        [TestCase(2, ExpectedResult = true)]
        [TestCase(3, ExpectedResult = false)]
        [TestCase(4, ExpectedResult = true)]
        [TestCase(103, ExpectedResult = false)]
        [TestCase(108, ExpectedResult = true)]
        [TestCase(1531, ExpectedResult = false)]
        [TestCase(1600, ExpectedResult = true)]
        public bool IsEven(int integer)
        {
            return integer.IsEven();
        }
    }
}
