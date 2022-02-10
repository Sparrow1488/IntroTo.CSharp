using System;
using System.Collections.Generic;

namespace LearnSharp4.TestableLibrary
{
    public sealed class BookShop
    {
        public BookShop(string title)
        {
            _title = title;
            _books = InitializeBooks();
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

            return BuyProcess(bookTitle, wallet);
        }

        private bool BuyProcess(string bookTitle, Wallet wallet)
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

        private Dictionary<string, int> InitializeBooks()
        {
            var result = new Dictionary<string, int>();

            result.Add("451 градус по Фаренгейту", 250);
            result.Add("1981", 500);
            result.Add("Скотный двор", 280);
            result.Add("Робин Гуд", 120);
            result.Add("Робинзон крузо", 500);

            return result;
        }

        
    }

    public class Wallet
    {
        public Wallet(int startBalance)
        {
            if (startBalance < 0)
                throw new ArgumentException("Money is only positive value!");

            _money = startBalance;
        }

        public int Money
        {
            get { return _money; }
        }
        private int _money;

        public void Add(int moneyAmount)
        {
            if (moneyAmount < 0)
                throw new ArgumentException("You can add only positive money value");

            _money += moneyAmount;
        }

        public int Get(int moneyAmount)
        {
            var result = 0;
            if (moneyAmount < 0)
                throw new ArgumentException("You can get only positive value of money");
            if (moneyAmount > _money)
                throw new ArgumentException("Your valance is lower");

            _money -= moneyAmount;
            result = moneyAmount;

            return result;
        }
    }

}
