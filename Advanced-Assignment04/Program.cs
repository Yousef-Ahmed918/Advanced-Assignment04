using System.Diagnostics;
using Advanced_Assignment04.Part01;

namespace Advanced_Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Book> books = new List<Book>
            {
                new Book("12s","in the heart of the sea",new string[]{"Johny deep"},new DateTime(2011,12,10),550),
                new Book("12b","harry potter",new string[]{"voldamort"},new DateTime(2005,9,9),850)
            };
            LibraryEngine.GetBook getBookTitle=BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks(books, getBookTitle);
         
            LibraryEngine.GetBook GetISBN= delegate (Book b) { return b.ISBN; };
            LibraryEngine.ProcessBooks(books, GetISBN);

            Func<Book,DateTime> func= B => B.PublicationDate;

            foreach (Book book in books)
            {
                Console.WriteLine(func(book));
            }
        }
    }
}
