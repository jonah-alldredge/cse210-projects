using System;
public class Comment
{
    private string _name;
    private string _comment;

    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
        // GetWholeText();
    }
    public string GetComment()
    {
        string writeComment = "Name: " + _name + "\nComment: " + _comment;
        return writeComment;
    }
}