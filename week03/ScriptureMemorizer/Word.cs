using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    //Constructor
    public Word (string text)
    {
        _text = text;
        _isHidden = false;
    }

    //Hide method 
    public void HideTheWord()
    {
        _isHidden = true;
    }

    //Show the word method
    public void ShowTheWord()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    //Display method for each word 
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string hiddenWord = "";
            foreach(char letter in _text)
            {
                if (char.IsPunctuation(letter))
                {
                    hiddenWord += letter;
                }
                else
                {
                    hiddenWord += '_';
                }
            }
            return hiddenWord;
        }
        else
        {
            return _text;
        }
    }
}