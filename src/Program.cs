using System;

namespace Calculator
{
  class Program
  {
    static int Add(int x, int y)
    {
      return x + y;
    }

    static int Subtract(int x, int y) 
    {
        return x - y;
    }

    static int Multiply(int x, int y)
    {
        return x * y;
    }

    static int Divide(int x, int y)
    {
        return x / y;
    }

    static void Main(string[] args)
    {
        while (true) {
        Console.WriteLine("Enter a basic calculation:");
        string userInput = Console.ReadLine();

        string[] formattedInput = userInput.Split();
        
        int firstNum = int.Parse(formattedInput[0]);
        int secondNum = int.Parse(formattedInput[2]);
        string function = formattedInput[1];

        if (userInput == "q")
        {
            break;
        } 
        // else-if (function == "+") {
        //     int result = Add(firstNum, secondNum);
        //     Console.WriteLine($"{userInput} equals {result}");
        // } else {
        //     Console.WriteLine("Don't know buddy");
        // }
        }

    }  
  }
}