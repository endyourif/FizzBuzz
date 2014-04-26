using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public object Calculate(int p)
        {
            if (p < 1)
                throw new IndexOutOfRangeException();
            if (p % 15 == 0)
                return "FizzBuzz";
            if (p % 3 == 0)
                return "Fizz";
            if (p % 5 == 0)
                return "Buzz";

            return p;
        }
    }
}
