using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    //Constructor initialise the data
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        _words = new List<Word>();

        string[] words = text.Split(" ");

        foreach(string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    //Check and hide each word 
    public void HideRandomWords(int numberToHide)
    {
        List<Word> allWords = new List<Word>();

        foreach(Word word in _words)
        {
            if(!word.IsHidden())
            {
                allWords.Add(word);
            }
        }

        for(int i = 0; i  < numberToHide && allWords.Count > 0; i++)
        {
            int randIndex = _random.Next(allWords.Count);

            allWords[randIndex].HideTheWord();
            allWords.RemoveAt(randIndex);
        }
    }

    //Display words 
    public string GetDisplayText()
    {
        List<string> myDisplayWords = new List<string>();

        foreach(Word word in _words)
        {
            myDisplayWords.Add(word.GetDisplayText());
        }

        return ($"{_reference.GetDisplayText()} {string.Join(' ', myDisplayWords)}");
    }

    //Check if word is hidden 
    public bool IsCompletelyHidden()
    {
        foreach(Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}