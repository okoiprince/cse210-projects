using System;

class Program
{
    static void Main(string[] args)
    {
        // Program to get input from the user

        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine($"Your name is {lname}, {fname} {lname}");
    }
}