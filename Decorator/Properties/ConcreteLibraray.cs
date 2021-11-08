using System;

namespace Decorator.Properties
{
    public class ConcreteLibraray : Library
    {
        public override void BorrowBook(Borrower _borrower, Book _book)
        {
            Console.WriteLine(string.Format("借阅者：{0}, 借阅书籍：{1}", _borrower.Name, _book.BookName));
        }

        public override void ReturnBook(Book _book)
        {
            Console.WriteLine(String.Format("归还书籍：{0}", _book.BookName));
        }
    }
}