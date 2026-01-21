//Stores a LIST of journal entries
//Also handles file SAVE and file LOAD actions
using System.Security.Authentication.ExtendedProtection;
using System.IO;
using System.ComponentModel;
using System.Collections.Generic;

public class Journal()
{
    /*
    Attributes:
        -_entries
    */
    public List<JournalEntry> _entries = new List<JournalEntry>();
    /*Method:
        -AddEntry(Entry):void
        -Display():void
        -FileSave(string):void
        -FileUpload(string):void
    */
    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }
    public void Display()
    {
        foreach (JournalEntry entry in _entries)
        {
            string wholeEntry = "Date: " + entry._dateTime + "\nPrompt: " + entry._prompt + "\n> " + entry._entry;
            Console.WriteLine(wholeEntry);
        }

    }
    public void FileUpload(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] section = line.Split("~~");

            JournalEntry journalEntry = new JournalEntry();
            journalEntry._dateTime = section[0];
            journalEntry._prompt = section[1];
            journalEntry._entry = section[2];

            _entries.Add(journalEntry);
        }
    }
    public void FileSave(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (JournalEntry entry in _entries)
            {
                string wholeEntry = ($"Date: {entry._dateTime}" + "~~" + $"Prompt: {entry._prompt}" + "~~" + $"> {entry._entry}");
                outputFile.WriteLine(wholeEntry);
            }
        }
        Console.WriteLine("Saved Entries");
    }
}