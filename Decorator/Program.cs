using System;
using Decorator.Properties;

namespace Decorator
{
    internal class Program
    {
        //装饰器模式
        
        //定义：动态地给对象添加一些额外的职责或者行为，装饰器模式相比于生成子类更为灵活

        //类别：结构型模式
        
        public static void Main(string[] args)
        {
            Book book = new Book("天方夜谭");
            Borrower borrower = new Borrower("jjl");
            CountingLibrary _library = new CountingLibrary(new ConcreteLibraray());
            _library.ReturnBook(book);
            _library.BorrowBook(borrower, book);
            Console.WriteLine("=========================");
            SellingLibrary library = new SellingLibrary(_library);
            library.ReturnBook(book);
            library.BorrowBook(borrower, book);
            library.SellBook(book);
        }
    }
}