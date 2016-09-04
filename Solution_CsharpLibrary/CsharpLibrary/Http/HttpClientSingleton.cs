using System.Net.Http;

namespace CsharpLibrary.Http
{
    /// <summary>
    /// Creating and disposing of new HttpClient() can lead to exhausting the sockets available
    /// Use a single instance of HttpClient for the whole app
    /// https://github.com/mspnp/performance-optimization/blob/master/ImproperInstantiation/docs/ImproperInstantiation.md
    /// </summary>
    public class HttpClientSingleton
    {
        private static HttpClient httpClient;

        private HttpClientSingleton() { }

        public static HttpClient HttpClient
        {
            get
            {
                if (httpClient == null)
                {
                    httpClient = new HttpClient();
                }
                return httpClient;
            }
        }
    }
}
