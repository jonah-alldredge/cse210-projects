using System;

namespace library_demo
{
    public class Book
    {
        protected string _author = "";
        protected string _title = ""; // Protected means that any child classes can access the variables

        public Book()
        {
            _author = "Anonymous";
            _title = "Unknown";
        }

        public Book(string author, string title)
        {
            
        }

        public void SetAuthor(string author)
        {
            _author = author;
        }
        public string GetAuthor()
        {
            return _author;
        }
        public void SetTitle(string title)
        {
            _title = title;
        }
        public string GetTitle()
        {
            return _title;
        }
        public string GetBookInfo()
        {
            return $"{_title} by {_author}";
        }
    }
}