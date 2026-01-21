//Represents a SINGLE journal entry
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

//DateTime today = DateTime.Today;
public class JournalEntry()
{
    /*Attributes:
        -_prompt
        -_entry
        -_dateTime
    */
    public string _entry;
    public string _prompt;
    public string _dateTime;

    /*Method:
        -Display():void
        Displaying prompt
    */
    public void Display()
    {
        PromptGenerator prompt = new PromptGenerator();
        _prompt = prompt.DisplayRandom();
        Console.WriteLine($"> {_prompt}");
    }
}