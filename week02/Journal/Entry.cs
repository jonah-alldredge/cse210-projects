//Represents a SINGLE journal entry
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

//DateTime today = DateTime.Today;
public class Entry()
{
    /*Attributes:
        -_prompt
        -_entry
        -_dateTime
    */
    public string _entry;
    public string _prompt;
    public DateTime _dateTime;

    /*Method:
        -Display():void
        Displaying prompt
    */
    public void Display()
    {
        PromptGenerator prompt = new PromptGenerator();
        string _prompt = prompt.DisplayRandom();
        Console.WriteLine($">{_prompt}");
    }
}