public class Video
{
    private string _title;
    private string _author;
    private int _length;
    List<Comment> commentsList = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void GetWholeText()
    {
        string text = "Title of Video: " + _title + "\nAuthor: " + _author + "\nLength of Video: " + _length + " seconds";
        Console.WriteLine(text);
    }
    public void GetComment(Comment comment)
    {
        commentsList.Add(comment);
    }

}