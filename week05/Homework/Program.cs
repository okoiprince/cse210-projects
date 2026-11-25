using System;

class Program
{
    static void Main(string[] args)
    {
        //Base object for the super class
        Assignment a1 = new Assignment("Julius Wonder", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        //Child class objects
        MathAssignment a2 = new MathAssignment("Rihanna Gandy", "Fractions", "9.2", "7-18");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Prince Okoi", "African History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}