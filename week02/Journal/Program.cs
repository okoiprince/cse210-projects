using System;

class Program
{
    static void Main(string[] args)
    {
        string fileName;
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        //Iterate Action
        while (running)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                //Get prompt Randomly
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(prompt);
                string response = Console.ReadLine();

                Entry entry = new Entry();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                //Call and Assign the data to member variables
                entry._date = dateText;
                entry._promptText = prompt;
                entry._entryText = response;

                journal.AddEntry(entry);
            }
            
            //Display File
            else if (option == "2")
            {
                journal.DisplayAll();
            }

            //Save the file 
            //Exceed the requirements, Also show file path.
            else if (option == "3")
            {
                Console.Write("Enter filename: ");
                fileName  = Console.ReadLine();

                journal.SaveToFile("../../../"+fileName);
            }

            //Load file 
            //Exceed the requirements, Show message if file is loaded successfully.
            else if (option == "4")
            {
                Console.Write("Enter filename: ");
                fileName = Console.ReadLine();

                journal.LoadFromFile("../../../"+fileName);
            }
            else if (option == "5")
            {
                running = false;
            }
            //Exceed the requirements, if a user enters wrong input.
            else
            {
                Console.WriteLine("Invalid option. Do you want to try again.");
            }
        }
    }
}