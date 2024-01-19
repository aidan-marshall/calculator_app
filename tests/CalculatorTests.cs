using System;
using Xunit;
using Moq;

// Imports Example File from TestProject
using CalculatorApp.Example;

namespace CalculatorApp.UnitTests.Example
{
    public class CalculatorTests
    {
        private readonly Calculator _newcalculator;
        
        public CalculatorTests()
        {
            _newcalculator = new Calculator();
        }
        
        // First Test for NewMethod
        [Fact]
        public void TwoPlusTwoEqualsFour()
        {
            int result = _newcalculator.Add(2, 2);
            int expectedResult = 4;


            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TwentyMinusFiveEqulasFifteen() 
        {
            int result = _newcalculator.Subtract(10, 5);
            int expectedResult = 5;

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void FiveMultipliedByFiveEqualsTwentyFive() {

            int result = _newcalculator.Multiply(5, 5);
            int expectedResult = 25;

            Assert.Equal(expectedResult, result);
    
        }

        [Fact]
        public void TwentyDividedByTwoEqualsTen() {

            int result = _newcalculator.Divide(20, 2);
            int expectedResult = 10;

            Assert.Equal(expectedResult, result);
        }

    }
}