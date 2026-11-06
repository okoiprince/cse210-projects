using System;
using System.Runtime.ExceptionServices;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        //Program to determine grade score

        string letter = " ";
        double score;
        string grade = " ";
        string sign = "";

        Console.WriteLine("What is your percentage score? ");
        score = Convert.ToDouble(Console.ReadLine());

        if (score >= 90)
        {
            grade = "A";

        }
        else if (score >= 80)
        {
            grade = "B";

        }
        else if (score >= 70)
        {
            grade = "C";
 
        }
        else if (score >= 60)
        {
            grade = "D";
            
        }
        else 
        {
            grade = "F";
            
        }

        //User Passed or Failed 
        if (score >= 60)
        {
            letter = "Congratulations You've Passed ";
        }
        else
        {
            letter = "Sorry you have to put more effort, you Failed";

        }

        //Determine the grade sign
        int last_digit = (int)Math.Floor(score) % 10;

        if (last_digit >= 7)
        {
            sign = "+";
        }
        else if (last_digit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        //Exceptional grades
        if (grade == "A" && sign == "+" || grade == "F")
        {
            sign = "";
        }

        //Display to Terminal
        Console.WriteLine();
        Console.WriteLine($"Message: {letter}");
        Console.WriteLine($"Grade: {grade}{sign}");

        //Further Help
        if (score < 60)
        {
            Console.WriteLine(" Do you need help? please contact your Teacher.");
        }


    }
}