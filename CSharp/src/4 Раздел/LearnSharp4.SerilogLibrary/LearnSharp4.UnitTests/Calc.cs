namespace LearnSharp4.UnitTests
{
    public class Calc
    {
        public int Sum(params int[] values)
        {
            int sum = 0;
            foreach (var num in values) 
            {
                sum += num;
            }
            return sum;
        }
    }
}
