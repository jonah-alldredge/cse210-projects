using System;
using System.ComponentModel;


// THE PURPOSE OF THIS PAGE: Keeps track of both the reference and the text of the scripture. 
// Can hide words and get the rendered display of the text
// This page should be the main hub of everything

// I need to separate the scripture from the text. So essentially put it into the reference page and remove

public class Scripture
{
    private Reference _reference;
    List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text)
    {
        string[] wordList = text.Split(' ');
        foreach (string word in wordList)
        {
            Word getWord = new Word(word);
             _words.Add(getWord);
        }
        _reference = reference;
    }
    public void HideRandomWords(int numberToHide)
    {
        // You could pick a random number and that is how many times it loops through getting rid of numbers
        Random random = new Random();
        int counter = 0;

        int count = random.Next(1, 3);
        
        for (int i=1; i <= count; i++)
        {
            Word randomWord = _words[numberToHide];
            if (!randomWord.IsHidden())
            {
                randomWord.Hide();
                counter++;
            }
            numberToHide = random.Next(1, _words.Count());
        }
    }
    public string GetDisplayText()
    {
        while (IsCompletelyHidden())
        {   
        string individualWord = "";
        foreach (Word word in _words)
        {
            individualWord += word.GetDisplayText();
        }
        Random randomWord = new Random();
        HideRandomWords(randomWord.Next(0, _words.Count()));
        return _reference.GetDisplayText() + individualWord;
        }
    }
    public bool IsCompletelyHidden()
    {
        return true;
    }
}