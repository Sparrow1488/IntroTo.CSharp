using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort
{
    public class BubbleSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public override void Sort()
        {
            var count = ItemsList.Count;
            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < count - 1; i++)
                {
                    var a = ItemsList[i];
                    var b = ItemsList[i + 1];
                    if (a.CompareTo(b) == 1)
                    {
                        Swop(i, i + 1);
                    }
                }
                count--;
            }
        }


    }
}
