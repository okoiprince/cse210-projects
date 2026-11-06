using System;

class Program
{
    //Number Prediction Game
    static void Main(string[] args)
    {
        Random numberGenerator = new Random();
        int magic_number;
        int my_guess = -1;
        string message = "";
        string option ="yes";
        
        do 
        {

            int attempt = 0;

            //Option for continuity
            if (option == "yes")
            {
                magic_number = numberGenerator.Next(1,101);
            }
            else
            {
                Console.WriteLine("Wrong Option ");
                break;
            }

            //Get user guess
            do
            {
                Console.Write("What is your guess? ");
                my_guess = Convert.ToInt32(Console.ReadLine());

                attempt = attempt+1;

                if(magic_number > my_guess)
                {
                    message = "Higher";
                }
                if(magic_number < my_guess)
                {
                    message = "Lower";
                }
                if(magic_number == my_guess)
                {
                    message = "You guessed it! ";
                }

                Console.WriteLine(message);

            } while (magic_number != my_guess);

            //Display number of attempts 
            Console.WriteLine($"Number of Attempts = {attempt}");

            Console.Write("Do you want to play again? (yes or no) ");
            option = Console.ReadLine().ToLower();
            
        } while (option != "no");
    }
}