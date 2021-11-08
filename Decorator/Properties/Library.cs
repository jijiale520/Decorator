namespace Decorator.Properties
{
    public abstract class Library
    {
        public abstract void BorrowBook(Borrower _borrower, Book _book);
        public abstract void ReturnBook(Book _book);
    }
}