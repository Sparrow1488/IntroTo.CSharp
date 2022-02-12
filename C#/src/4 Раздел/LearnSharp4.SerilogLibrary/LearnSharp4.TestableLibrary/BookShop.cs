using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LearnSharp4.TestableLibrary
{
    public sealed class BookShop : IDisposable
    {
        public BookShop(string title = "BookShop")
        {
            _title = title;
        }

        public string Title { get => _title; }
        private readonly string _title = string.Empty;
        public IDictionary<string, int> Books { get => _books; }
        private Dictionary<string, int> _books = new Dictionary<string, int>();
        public IEnumerable<string> Errors { get => _errors; }
        private List<string> _errors = new List<string>();

        public bool Buy(string bookTitle, Wallet wallet)
        {
            if (bookTitle is null || wallet is null)
                throw new ArgumentNullException();

            return ExecuteBuyProcess(bookTitle, wallet);
        }

        public void SetBooks(Dictionary<string, int> books)
        {
            if (books is null)
                throw new ArgumentNullException();

            _books = books;
        }

        public void Dispose()
        {
            _books = null;
            Debug.WriteLine("Shop was disposed");
        }

        private bool ExecuteBuyProcess(string bookTitle, Wallet wallet)
        {
            var processedSuccess = false;
            if (_books.TryGetValue(bookTitle, out var price))
            {
                if (wallet.Money >= price)
                {
                    wallet.Get(price);
                    processedSuccess = true;
                }
                else
                {
                    _errors.Add("No money");
                    processedSuccess = false;
                }
            }
            else
            {
                _errors.Add($"No book named '{bookTitle}'");
            }
            return processedSuccess;
        }

        
    }
}
