using System;

namespace Decorator.Properties
{
    public class SellingLibrary : LibraryDecorator
    {
        public SellingLibrary(Library _library) : base(_library)
        {
        }

        public void SellBook(Book _book)
        {
            Console.WriteLine("出售书籍 ："+_book.BookName);
        }
    }
}