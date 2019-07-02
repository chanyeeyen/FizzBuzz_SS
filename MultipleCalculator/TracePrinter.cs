using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MultipleCalculator
{
    class TracePrinter : IPrinter
    {
        public void Printer(List<string> result)
        {
            Trace.WriteLine("\nResult Showing Here >>");
            Trace.WriteLine(result.Aggregate((i, j) => i + "\n" + j));
        }
    }
}
