using System;
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

        [Fact]
        public void FiveMultipliedByTenEqualsFifty()
        {
            // ARRANGE
            var input = "5 * 10";
            var calculator = new Calculator();

            // ACT
            var result = calculator.Solve(input);

            // ASSERT
            Assert.Equal(50, result);
        }

        [Fact]
        public void OneDividedByOneEqualsOne()
        {

            // ARRANGE
            var input = "1 / 1";
            var calculator = new Calculator();

            // ACT
            var result = calculator.Solve(input);

            // ASSERT
            Assert.Equal(1, result);
        }

        [Fact]
        public void TenDividedByTwoEqualsFive()
        {

            // ARRANGE
            var input = "10 / 2";
            var calculator = new Calculator();

            // ACT
            var result = calculator.Solve(input);

            // ASSERT
            Assert.Equal(5, result);
        }

        [Fact]
        public void TenDividedByZeroThrowsDivideByZeroException()
        {
            // ARRANGE
            var input = "10 / 0";
            var calculator = new Calculator();

            // ACT

            // ASSERT
            Assert.Throws<DivideByZeroException>(() => calculator.Solve(input));
        }

        [Fact]
        public void ZeroDividedByTenShouldEqualZero()
        {
            // ARRANGE
            var input = "0 / 10";
            var calculator = new Calculator();

            // ACT
            var result = calculator.Solve(input);

            // ASSERT
            Assert.Equal(0, result);
        }

        [Fact]
        public void AddingTenDecimalOneWithFiveShouldEqualFifteenDecimalOne()
        {

            // ARRANGE
            var input = "10,1 + 5";
            var calculator = new Calculator();
            decimal expected = 15.1M; 

            // ACT
            var result = calculator.Solve(input);

            // ASSERT
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MultiplyingTenDecimalOnebyFiveShouldEqualFiftyDecimalFive()
        {

            // ARRANGE
            var input = "10,1 * 5";
            var calculator = new Calculator();
            decimal expected = 50.5M;

            // ACT
            var result = calculator.Solve(input);

            // ASSERT
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SubtractingTenDecimalOnebyFiveShouldEqualFiveDecimalOne()
        {

            // ARRANGE
            var input = "10,1 - 5";
            var calculator = new Calculator();
            decimal expected = 5.1M;

            // ACT
            var result = calculator.Solve(input);

            // ASSERT
            Assert.Equal(expected, result);
        }

        [Fact]
        public void DividingTenDecimalOnebyFiveShouldEqualTwoDecimalZeroTwo()
        {

            // ARRANGE
            var input = "10,1 / 5";
            var calculator = new Calculator();
            decimal expected = 2.02M;

            // ACT
            var result = calculator.Solve(input);

            // ASSERT
            Assert.Equal(expected, result);
        }

        [Fact]
        public void InputtingThreeDifferentEquationsShouldReturnTheNumberThree()
        {
            // ARRANGE
            var input = "10 + 5 - 10 + 10";
            var calculator = new Calculator();

            // ACT
            var result = calculator.OperatorCount(input);

            // ASSERT
            Assert.Equal(3, result);

        }

        [Fact]
        public void InputtingFiveDifferentEquationsShouldReturnTheNumberFive()
        {
            // ARRANGE
            var input = "10 + 5 - 10 + 10 + 15 - 13";
            var calculator = new Calculator();

            // ACT
            var result = calculator.OperatorCount(input);

            // ASSERT
            Assert.Equal(5, result);

        }

        [Fact]
        public void AddingFiveToTenMultipliedByTenShouldEqualOneHundredAndFive()
        {
            // ARRANGE
            var input = "5 + 10 * 10";
            var calculator = new Calculator();

            // ACT
            var result = calculator.Solve(input);

            // ASSERT
            Assert.Equal(150, result);
        }

    }
}