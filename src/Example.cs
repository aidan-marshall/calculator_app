using System;

namespace CalculatorApp.Example
{
    public class Calculator
    {
        public decimal? Solve(string input)
        {
            decimal? result = null;

            var splitInput = input.Split(" ");
            decimal? num1 = decimal.Parse(splitInput[0]);
            var @operator = splitInput[1];
            decimal? num2 = decimal.Parse(splitInput[2]);


            if (num2 == 0)
            {
                throw new DivideByZeroException("Attempted to divide by zero.");
            }

            switch (@operator)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;

                case "/":
                    result = num1 / num2;
                    break;
            }

            return result;
        }
    }
}