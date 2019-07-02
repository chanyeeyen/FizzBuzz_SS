using MultipleCalculatorAssembly;
using System;
using System.Linq;
using Xunit;

namespace MultipleCalculatorTestProject
{
    public class MultipleCalculatorUnitTest
    {
        private MultipleCalculator _mutipleCalculator;

        public MultipleCalculatorUnitTest()
        {
            _mutipleCalculator = new MultipleCalculator();
        }

        [Fact]
        public void Test_ValidMinMaxPositiveValue_ShowCorrectCount()
        {
            //Arrange
            int minValue = 1;
            int maxValue = 100;

            int fizzActualCount = 27;
            int buzzActualCount = 14;
            int fizzbuzzActualCount = 6;
            int normalActualCount = 53;

            //Act 
            var result = _mutipleCalculator.PrimeCalculation(minValue, maxValue);

            //Assert
            int fizzExpectedCount = result.Where(i => i.Equals("Fizz")).Count();
            int buzzExpectedCount = result.Where(i => i.Equals("Buzz")).Count();
            int fizzbuzzExpectedCount = result.Where(i => i.Equals("FizzBuzz")).Count();
            int normalExpectedCount = result.Where(i => !i.Equals("Fizz") && !i.Equals("Buzz") && !i.Equals("FizzBuzz")).Count();

            Assert.Equal(fizzExpectedCount, fizzActualCount);
            Assert.Equal(buzzExpectedCount, buzzActualCount);
            Assert.Equal(fizzbuzzExpectedCount, fizzbuzzActualCount);
            Assert.Equal(normalExpectedCount, normalActualCount);
        }

        [Fact]
        public void Test_InvalidMinMax_ThrowException()
        {
            //Arrange
            int minValue = 100;
            int maxValue = 1;

            //Act & Assert
            Assert.Throws<ArgumentException>(() => _mutipleCalculator.PrimeCalculation(minValue, maxValue));
        }

        [Fact]
        public void Test_ValidMinMaxNegativeValue_ShowCorrectCount()
        {
            //Arrange
            int minValue = -100;
            int maxValue = 100;

            int fizzActualCount = 54;
            int buzzActualCount = 28;
            int fizzbuzzActualCount = 13;
            int normalActualCount = 106;

            //Act 
            var result = _mutipleCalculator.PrimeCalculation(minValue, maxValue);

            //Assert
            int fizzExpectedCount = result.Where(i => i.Equals("Fizz")).Count();
            int buzzExpectedCount = result.Where(i => i.Equals("Buzz")).Count();
            int fizzbuzzExpectedCount = result.Where(i => i.Equals("FizzBuzz")).Count();
            int normalExpectedCount = result.Where(i => !i.Equals("Fizz") && !i.Equals("Buzz") && !i.Equals("FizzBuzz")).Count();

            Assert.Equal(fizzExpectedCount, fizzActualCount);
            Assert.Equal(buzzExpectedCount, buzzActualCount);
            Assert.Equal(fizzbuzzExpectedCount, fizzbuzzActualCount);
            Assert.Equal(normalExpectedCount, normalActualCount);
        }
    }
}
