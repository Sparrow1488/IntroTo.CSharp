using System;
using System.Threading.Tasks;

namespace LearnSharp4.Retry
{
    internal interface IHttpClient
    {
        Task<string> GetStringAsync(Uri url);
        Task<string> GetStringUsingRetryAsync(Uri url);
    }
}
