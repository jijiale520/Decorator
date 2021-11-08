using System;

namespace Decorator.Properties
{
    public class CountingLibrary : LibraryDecorator
    {
        private int count = 0;
        
        public CountingLibrary(Library _library) : base(_library) {}
        
        public override void BorrowBook(Borrower _borrower, Book _book)
        {
            base.library.BorrowBook(_borrower, _book);
            count--;
            Console.WriteLine("借阅"+_book + "书籍数量：" + count);
        }

        public override void ReturnBook(Book _book)
        {
            base.library.ReturnBook(_book);
            count++;
            Console.WriteLine("归还"+_book + "书籍数量：" + count);
        }
    }
}