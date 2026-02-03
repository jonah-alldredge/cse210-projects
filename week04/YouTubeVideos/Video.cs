public class Video
{
    private string _title;
    private string _author;
    private int _length;
    List<Comment> _commentList = new List<Comment>();
    

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
        Console.WriteLine("Number of Comments: " + NumberOfComments());
        Console.WriteLine("Comments: ");
        foreach (Comment comment in _commentList)
        {
            Console.WriteLine(comment.GetComment());
        }
    }
    public void AddComment(Comment comment)
    {
        _commentList.Add(comment);
    }
    
    public int NumberOfComments()
    {
        return _commentList.Count();
    }
}