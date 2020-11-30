using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort
{
    public class AlgorithmBase<T> where T: IComparable
    {
        public List<T> ItemsList = new List<T>();

        protected void Swop(int positionA, int positionB)
        {
            if((positionA < ItemsList.Count) && (positionB < ItemsList.Count))
            {
                var temp = ItemsList[positionA];
                ItemsList[positionA] = ItemsList[positionB];
                ItemsList[positionB] = temp;
            }
        }
        public virtual void Sort()
        {
            ItemsList.Sort();
        }
    }
}
