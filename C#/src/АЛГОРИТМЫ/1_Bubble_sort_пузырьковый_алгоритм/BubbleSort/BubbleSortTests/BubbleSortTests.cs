using Microsoft.VisualStudio.TestTools.UnitTesting;
using BubbleSort;
using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort.Tests
{
    [TestClass()]
    public class BubbleSortTests
    {
        public void SortTest()
        {
            var bubble = new BubbleSort<int>();
            var rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                bubble.ItemsList.Add(rnd.Next(0, 100));
            }
            bubble.Sort();
        }
    }
}