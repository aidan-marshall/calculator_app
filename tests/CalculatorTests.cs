using System;
using Xunit;
using Moq;

// Imports Example File from TestProject
using CalculatorApp.Example;

namespace CalculatorApp.UnitTests.Example
{
    public class CalculatorTests
    {
        [Fact]
        public void AddingOnePlusOneEqualsTwo() 
        {
            // ARRANGE
            var input = "1 + 1";
            var calculator = new Calculator();

            // ACT
            var result = calculator.Solve(input);

            // ASSERT
            Assert.Equal(2, result);
        }

        [Fact]
        public void AddingTenPlusTenEqualsTwenty()
        {

            // ARRANGE
            var input = "10 + 10";
            var calculator = new Calculator();

            // ACT
            var result = calculator.Solve(input);

            // ASSERT
            Assert.Equal(20, result);
        }

        [Fact]
        public void SubtractingOneFromOneEqualsZero()
        {

            // ARRANGE
            var input = "1 - 1";
            var calculator = new Calculator();

            // ACT
            var result = calculator.Solve(input);

            // ASSERT
            Assert.Equal(0, result);
        }

        [Fact]
        public void SubtractingNinetySixFromFiftyEightEqualsThirtyEight()
        {

            // ARRAGE
            var input = "96 - 58";
            var calculator = new Calculator();

            // ACT
            var result = calculator.Solve(input);

            // ASSERT
            Assert.Equal(38, result);
        }

        [Fact]
        public void OneMultipliedByOneEqualsOne()
        {

            // ARRANGE
            var input = "1 * 1";
            var calculator = new Calculator();

            // ACT
            var result = calculator.Solve(input);

            // ASSERT
            Assert.Equal(1, result);
        }
    }
}