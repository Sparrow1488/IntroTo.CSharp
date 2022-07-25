using Polly;
using Polly.Retry;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace LearnSharp4.Retry
{
    internal class HttpRetryClient : IHttpClient
    {
        public HttpRetryClient() =>
            _retryPolicy = Policy.Handle<HttpRequestException>()
                            .WaitAndRetryAsync(_maxRetries, sleepDuration => TimeSpan.FromMilliseconds(300));

        private readonly AsyncRetryPolicy _retryPolicy;
        private readonly int _maxRetries = 5;

        public async Task<string> GetStringAsync(Uri url)
        {
            string response;
            var random = new Random();
            try
            {
                if (random.Next(1, 3) == 1)
                    throw new HttpRequestException("Http fake request exception");
                response = await SendGetRequestAsync(url);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("     EXCEPTION => " + ex.Message);
                throw ex;
            }

            return response;
        }

        public async Task<string> GetStringUsingRetryAsync(Uri url) =>
            await _retryPolicy.ExecuteAsync(() => GetStringAsync(url));

        private async Task<string> SendGetRequestAsync(Uri url)
        {
            string response = string.Empty;
            Console.WriteLine("GET => " + url.ToString());
            using (var client = new HttpClient())
                response = await client.GetStringAsync(url);
            return response;
        }
    }
}
