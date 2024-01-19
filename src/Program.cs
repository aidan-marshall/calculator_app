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

    static bool NotValid(string? userInput) {
        userInput = userInput.ToLower();
        if (userInput == "q") {
            return false;
        }

        return string.IsNullOrEmpty(userInput) || userInput.Any(char.IsLetter)
                || userInput.Length < 5 || !char.IsDigit(userInput, 0) || !char.IsDigit(userInput, 4);
    }

    static string GetUserInput() {
        Console.WriteLine("Enter a basic calculation. User 'help' for more information.");
        string? userInput = Console.ReadLine();

        while (NotValid(userInput))  {
            Console.WriteLine("Invalid input. Please enter a calculation in the following format: 1 + 1 - use the help command to see available functions.");
            userInput = Console.ReadLine();
        }
        return userInput;
    }

    static void Main(string[] args)
    {
        while (true) {
        Console.WriteLine("Enter a basic calculation:");
        string userInput = GetUserInput();

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
        else if (function == "*") {
            int result = Multiply(firstNum, secondNum);
            DisplayResult(userInput, result.ToString());
        }
        else {
            Console.WriteLine("An error has occured.");
            break;
        }
        }
    }  
  }
}