namespace Decorator.Properties
{
    public class LibraryDecorator : Library
    {
        protected Library library;

        public LibraryDecorator(Library _library)
        {
            this.library = _library;
        }
        
        public override void BorrowBook(Borrower _borrower, Book _book)
        {
            this.library.BorrowBook(_borrower, _book);
        }

        public override void ReturnBook(Book _book)
        {
            this.library.ReturnBook(_book);
        }
    }
}