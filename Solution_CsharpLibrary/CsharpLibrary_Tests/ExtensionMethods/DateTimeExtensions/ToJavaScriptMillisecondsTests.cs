using System;
using CsharpLibrary.ExtensionMethods;
using NUnit.Framework;

namespace CsharpLibrary_Tests.ExtensionMethods.DateTimeExtensions
{
    [TestFixture]
    public class ToJavaScriptMillisecondsTests
    {
        [Test]
        public void ToJavaScriptMilliseconds_Past()
        {
            var dateTime = new DateTime(1982, 9, 21, 11, 43, 12);
            Assert.AreEqual(dateTime.ToJavaScriptMilliseconds(), 401452992000);
        }

        [Test]
        public void ToJavaScriptMilliseconds_Future()
        {
            var dateTime = new DateTime(2020, 1, 31, 16, 55, 1);
            Assert.AreEqual(dateTime.ToJavaScriptMilliseconds(), 1580489701000);
        }
    }
}
