using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LearnSharp4.TestableLibrary.Tests
{
    [TestClass]
    public class BookShopTests
    {
        private static BookShop _shop;

        [ClassInitialize] // запускается перед запуском тестов в классе
        public static void ShopInitialize() // обязательно static!
        {
            _shop = new BookShop();
            var books = new Dictionary<string, int>();
            books.Add("451 градус по Фаренгейту", 250);
            books.Add("1981", 500);
            books.Add("Скотный двор", 280);
            books.Add("Робин Гуд", 120);
            books.Add("Робинзон крузо", 500);

            _shop.SetBooks(books);
            Debug.WriteLine("Shop init");
        }

        [ClassCleanup] // запускается после выполнения тестов
        public static void ShopCleanup()
        {
            _shop.Dispose();
            Debug.WriteLine("Books cleaned");
        }

        [TestMethod]
        public void Buy_BuyBookWithNotEnoughMoney_FalseReturned()
        {
            // arrange 
            var wallet = new Wallet(250);
            var bookShop = _shop;
            var expected = false;

            // act
            var buySuccess = bookShop.Buy("1981", wallet); // price = 500

            // assert
            Assert.AreEqual(buySuccess, expected);
        }

        [TestMethod]
        public void Buy_NullInputWallet_NullException()
        {
            var shop = _shop;

            Assert.ThrowsException<ArgumentNullException>(() => shop.Buy("1981", null));
        }
    }
}