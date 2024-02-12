using System;
using System.Text.RegularExpressions;

namespace CalculatorApp.Example
{
    public class Calculator
    {
        public int OperatorCount(string input) 
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == '+' || c == '-' || c == '*' || c == '/') 
                {
                    count++;
                }
            }

            return count;
        }

        public decimal? Solve(string input)
        {
            decimal? result = null;
            string[]? splitInput = input.Split(" ");
            decimal? num1;
            string? @operator;
            decimal? num2;


            int calculations = OperatorCount(input);

            for (int i = 0; i < calculations; i++) {

                if (i == 0)
                {
                    num1 = decimal.Parse(splitInput[0]);
                    @operator = splitInput[1];
                    num2 = decimal.Parse(splitInput[2]);
                }
                else 
                {
                    num1 = result;
                    int operatorIndex = 3;
                    int num2Index = 4;
                    @operator = splitInput[operatorIndex];
                    num2 = decimal.Parse(splitInput[num2Index]);
                    operatorIndex++;
                    num2Index++;
                }


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
            }

            return result;
        }
    }
}