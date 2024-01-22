using System;

namespace CalculatorApp.Example
{
  public class Calculator 
  {
    public int Solve(string input) 
    {
      var splitInput = input.Split(" ");
      var num1 = int.Parse(splitInput[0]);
      var @operator = splitInput[1];
      var num2 = int.Parse(splitInput[2]);

      switch (@operator) 
      {
        case "+":
        return num1 + num2;

        case "-":
        return num1 - num2;

        default:
        return 403;
      }




    }

  }
}