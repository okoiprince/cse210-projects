using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Function call to action

        DisplayWelcome();
        DisplayResult();
    }

    static void DisplayWelcome()
    {
       Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static double PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        double userNumber = Convert.ToDouble(Console.ReadLine());

        return userNumber;
    }

    static  double SquareNumber()
    {
        double number = PromptUserNumber();

        double squareNumber = number * number;

        return squareNumber;
    }

    //Call and display the result
    static void DisplayResult()
    {
        string name = PromptUserName();
        double squareNumber = SquareNumber();

        Console.WriteLine();
        Console.WriteLine($"{name} the square of your number is {squareNumber}");
    }

}