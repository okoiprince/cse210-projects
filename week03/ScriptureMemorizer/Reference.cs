using System;
using System.Runtime.InteropServices;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //Constructor overloading
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
        
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter; 
        _verse = startVerse;
        _endVerse = endVerse;
    }

    //Display the verse and chapter base on decision 
    public string GetDisplayText()
    {
        if (_verse == _endVerse)
        {
            return ($"{_book} {_chapter}:{_verse}");
        }
        else
        {
            return($"{_book} {_chapter}:{_verse}-{_endVerse}");
        }
    }
}