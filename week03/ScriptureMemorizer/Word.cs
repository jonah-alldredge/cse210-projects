using System;
public class Word
{
    private string _text;
    private bool _isHidden;
    public Word(string text)
    {
        _text = text;

    }
    public void Hide()
    {
        string hiddenWord = "";
        foreach (char c in _text)
        {
            char u = '_';
            hiddenWord = hiddenWord + u;
        }
        _text = hiddenWord;
        _isHidden = true;
        GetDisplayText();
    }
    public void Show()
    {
        Console.Write(" " + _text);
    }
    public bool IsHidden()
    {
        if (_text.Contains('_'))
        {
            _isHidden = true;
            return _isHidden;
        }
        _isHidden = false;
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return " " + _text;
    }
}