using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Assignment04.Part01
{

    internal class LibraryEngine
    {
        public delegate string GetBook(Book book);
        public static void ProcessBooks(List<Book> bList, GetBook getBookTitle)
        {
            foreach (Book book in bList)
            {
                Console.WriteLine(getBookTitle(book));
            }
        }
    }
}
