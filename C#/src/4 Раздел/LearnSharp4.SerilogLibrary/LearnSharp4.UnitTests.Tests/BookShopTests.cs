using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LearnSharp4.TestableLibrary.Tests
{
    [TestClass()]
    public class BookShopTests
    {

        [TestMethod()]
        public void Buy_BuyBookWithNotEnoughMoney_FalseReturned()
        {
            // arrange 
            var wallet = new Wallet(250);
            var bookShop = new BookShop("BookShop");
            var expected = false;

            // act
            var buySuccess = bookShop.Buy("1981", wallet); // price = 500

            // assert
            Assert.AreEqual(buySuccess, expected);
        }

        [TestMethod]
        public void Buy_NullInputWallet_NullException()
        {
            var shop = new BookShop("BookShop");

            Assert.ThrowsException<ArgumentNullException>(() => shop.Buy("1981", null));
        }
    }
}