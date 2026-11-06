using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Create an empty list
        List<double> my_numbers = new List<double>();
        double number = -1;
        double sum = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Collect numbers from the user
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = Convert.ToDouble(Console.ReadLine());

            if (number != 0)
            {
                my_numbers.Add(number);
            }
        }

        // Display the numbers entered
        Console.WriteLine("Your numbers are:");

        foreach (double item in my_numbers)
        {
            Console.WriteLine(item);

            sum = sum+item;
        }

        // Calculate the sum, average, min and max numbers entered
        if (my_numbers.Count > 0)
        {
            double average = sum / my_numbers.Count;

            double largest_number = my_numbers.Max();
            var positive_number = my_numbers.Where(n => n > 0);
            var sorted_list = my_numbers.OrderBy(n=>n);

            Console.WriteLine();
            Console.WriteLine($"The Sum is: {sum}");
            Console.WriteLine($"The Average is: {average}");
            Console.WriteLine($"The Largest number is: {largest_number}");

            if (positive_number.Any())
            {
                double smallest_positive = positive_number.Min();

                Console.WriteLine($"The Smallest positive number is: {smallest_positive}");
            }
            else
            {
                Console.WriteLine("No Positive number found");
            }

            //Sort the list in ascending order
            Console.WriteLine();
            Console.WriteLine("The sorted list is: ");

            foreach(double item in sorted_list)
            {
                Console.WriteLine(item);
            }

        }
        else 
        {
            Console.WriteLine("No input numbers found");
        }
       
    
    }
}