namespace Decorator.Properties
{
    public class Book
    {
        private string bookName;

        public string BookName
        {
            get { return bookName; }
        }

        public Book(string _bookName)
        {
            this.bookName = _bookName;
        }
    }
}