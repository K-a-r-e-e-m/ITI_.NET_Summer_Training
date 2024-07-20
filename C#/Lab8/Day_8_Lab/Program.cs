using ClassLibrary1;
using System.Net.Http.Headers;

namespace Day_8_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("123-489-234", "Title 1", ["Author 1", "Author 2"],
                new DateTime(2020, 2, 5), 22.5m);
            Book b2 = new Book("765-432-764", "Title 2", ["Author 1", "Author 2"],
                new DateTime(2018, 6, 25), 29.99m);
            Book b3 = new Book("567-489-239", "Title 3", ["Author 1"],
                new DateTime(2023, 4, 8), 30);

            List<Book> books = new List<Book> { b1, b2, b3 };
            // A) User Defined Delegate Datatype
            //BDelegate<Book, String> del1 = BookFunctions.GetTitle;
            //LibraryEngine.ProcessBooks(books, del1);

            // B) BCL 
            Func<Book, String> del2 = BookFunctions.GetPrice;
            LibraryEngine.ProcessBooks(books, del2);

            // C) Anonymous Method (GetISBN)
            Func<Book, String>  del3 = delegate (Book B) { return B.ISBN ; };
            LibraryEngine.ProcessBooks(books, del3);

            // D) Lambda Expression
            LibraryEngine.ProcessBooks(books, B => B.PublicationDate.ToString());

        }
    }
}
