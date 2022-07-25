using System;
using System.Threading.Tasks;

namespace LearnSharp4.Retry
{
    internal class Program
    {
        private static IHttpClient _httpClient;
        private static readonly Uri _url = new Uri("https://google.com");

        private static async Task Main()
        {
            Console.WriteLine("LearnSharp4.Retry started");
            _httpClient = new HttpRetryClient();

            for (int i = 0; i < 30; i++)
            {
                var response = await _httpClient.GetStringUsingRetryAsync(_url);
                ShowResponseResult(response);
            }
        }

        private static void ShowResponseResult(string response)
        {
            if (!string.IsNullOrWhiteSpace(response)) {
                Console.WriteLine("Get response success");
            }
            else Console.WriteLine("Get response failed");
        }
    }
}
