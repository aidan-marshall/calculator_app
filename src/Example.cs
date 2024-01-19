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

      return num1 + num2;
    }

  }
}