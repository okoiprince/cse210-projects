using System;

class Program
{
    static void Main(string[] args)
    {
        string t = "";
        Reference myReference = new Reference(t, 3, 2);
        Scripture myScripture = new Scripture(myReference, t);
        Word myWord = new Word(t);
    }
}