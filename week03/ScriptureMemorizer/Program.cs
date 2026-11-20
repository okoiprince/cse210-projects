using System;

class Program
{
    //Main Code
    static void Main(string[] args)
    {
        //Scriptures
        Reference myReference1 = new Reference("Proverbs", 3, 5, 6);
        Reference myReference2 = new Reference("John", 3, 16);

        Reference myReference3 = new Reference("Enos", 1, 5, 6);

        //Scripture text
        string text1 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        string text2 = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        string text3 = "And there came a voice unto me, saying: Enos, thy sins are forgiven thee, and thou shalt be blessed. And I, Enos, knew that God could not lie; wherefore, my guilt was swept away.";
        
        //Scripture Objects
        Scripture myScripture1 = new Scripture(myReference1, text1);
        Scripture myScripture2 = new Scripture(myReference2, text2);
        Scripture myScripture3 = new Scripture(myReference3, text3);

        ScriptureLibrary myLibrary = new ScriptureLibrary();

        //Stretch Challenge Add the Scripture to Scripture Library
        myLibrary.AddScripture(myScripture1);
        myLibrary.AddScripture(myScripture2);
        myLibrary.AddScripture(myScripture3);

        //Get Random Scripture
        Scripture getScripture = myLibrary.GetRandomScripture();

        if (getScripture == null)
        {
            Console.WriteLine($"Scripture Library is Empty");
            return;
        }
        
        //Stretch Challenge, Get random Scripture then hide 3 words 
        while(!getScripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(getScripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine($"Press Enter to continue or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            getScripture.HideRandomWords(3);

        } 
    }
}