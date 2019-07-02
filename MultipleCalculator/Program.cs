using System;

namespace MultipleCalculator
{
    class Program
    {
        private static int minValue;
        private static int maxValue;
        private static int outputMethod = 0;

        static void Main(string[] args)
        {
            Init();

            var multipleCalculator = new MultipleCalculatorAssembly.MultipleCalculator();
            var result = multipleCalculator.PrimeCalculation(minValue, maxValue);

            IPrinter iPrinter;
            switch (outputMethod)
            {
                case 1: iPrinter = new ConsolePrinter(); break;
                case 2: iPrinter = new TracePrinter(); break;
                default: iPrinter = null; break;
            }
            iPrinter.Printer(result);
        }

        private static void Init()
        {
            minValue = 1;
            maxValue = 100;

            var isValidInput = false;
            while (!isValidInput)
            {
                Console.Write("Please select output method. \n1. Console.WriteLine \n2. Trace.WriteLine \n>>");
                string input = Console.ReadLine();

                int.TryParse(input, out outputMethod);
                if (outputMethod != 1 && outputMethod != 2)
                    Console.WriteLine("Incorrect input. Please insert 1 or 2. \n");
                else
                    isValidInput = true; 
            }
        }
    }
}
