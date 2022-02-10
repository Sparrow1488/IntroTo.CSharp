using System;

namespace LearnSharp4.TestableLibrary
{
    public class Calc
    {
        public int Sum(params int[] values)
        {
            if (values is null)
                throw new NullReferenceException($"Input ${values} could not be null!");

            int sum = 0;
            foreach (var num in values)
                sum += num;
            return sum;
        }
    }
}
