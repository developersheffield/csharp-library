using NUnit.Framework;

namespace CsharpLibrary_Tests.Http.HttpClientSingleton
{
    [TestFixture]
    public class Singleton
    {
        [Test]
        public void Singleton_Created()
        {
            var client = CsharpLibrary.Http.HttpClientSingleton.HttpClient;
            var result = client.GetAsync("http://www.google.co.uk").Result;
            Assert.IsTrue(result != null && result.IsSuccessStatusCode);
        }
    }
}
