using System;
using System.Collections.Generic;
using System.Linq;

namespace MultipleCalculator
{
    class ConsolePrinter : IPrinter
    {
        public void Printer(List<string> result)
        {
            Console.WriteLine("\nResult Showing Here >>");
            Console.WriteLine(result.Aggregate((i, j) => i + "\n" + j));
        }
    }
}
