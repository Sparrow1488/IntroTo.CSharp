using System;

namespace LearnSharp4.TestableLibrary
{
    public class Wallet
    {
        public Wallet(int startBalance)
        {
            if (startBalance < 0)
                throw new ArgumentException("Money is only positive value!");

            _money = startBalance;
        }

        public int Money { get => _money; }
        private int _money;

        public void Add(int moneyAmount)
        {
            if (moneyAmount < 0)
                throw new ArgumentException("You can add only positive money value");

            _money += moneyAmount;
        }

        public int Get(int moneyAmount)
        {
            if (moneyAmount < 0)
                throw new ArgumentException("You can get only positive value of money");
            if (moneyAmount > _money)
                throw new ArgumentException("Your valance is lower");

            _money -= moneyAmount;

            return moneyAmount;
        }
    }
}
