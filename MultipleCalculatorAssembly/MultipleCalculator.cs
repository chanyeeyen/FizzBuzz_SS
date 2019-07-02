using System;
using System.Collections.Generic;

namespace MultipleCalculatorAssembly
{
    public class MultipleCalculator
    {
        public List<string> PrimeCalculation(int min, int max)
        {
            if (min > max)
                throw new ArgumentException("Minimum value cannot greater than Maximum value.");

            var result = new List<string>();

            for (int i = min; i <= max; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    result.Add("FizzBuzz");
                else if (i % 3 == 0)
                    result.Add("Fizz");
                else if (i % 5 == 0)
                    result.Add("Buzz");
                else
                    result.Add(i.ToString());
            }

            return result;
        }
    }
}
