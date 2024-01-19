using System;

namespace Calculator
{
  public class Program
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

    static void DisplayResult(string userInput, string result) {
        Console.WriteLine($"{userInput} equals {result}");
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
            Console.ReadKey();
        } 
        else if (function == "+") {
            int result = Add(firstNum, secondNum);
            DisplayResult(userInput, result.ToString());
        }
        else if (function == "-") {
            int result = Subtract(firstNum, secondNum);
            DisplayResult(userInput, result.ToString());
        }
        else if (function == "/") {
            int result = Divide(firstNum, secondNum);
            DisplayResult(userInput, result.ToString());
        }
        else if (function == "x") {
            int result = Multiply(firstNum, secondNum);
            DisplayResult(userInput, result.ToString());
        }
        else {
            Console.WriteLine("Don't know buddy");
        }
        }

    }  
  }
}