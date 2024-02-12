using System;

namespace CalculatorApp.Example
{
  public class Calculator 
  {
    public int? Solve(string input)
    {
            int? result = null;
            var splitInput = input.Split(" ");
            int num1 = int.Parse(splitInput[0]);
            var @operator = splitInput[1];
            int num2 = int.Parse(splitInput[2]);

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