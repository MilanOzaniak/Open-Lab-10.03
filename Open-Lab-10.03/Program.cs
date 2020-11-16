using System;

namespace Open_Lab_10._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Title = "The Fellowship of the Ring";
            book.Author = "J. R. R. Tolkien";
            book.Category = "fantasy and adventure";
            book.Pages = 300;
            book.ReleaseDate = 1954;

            Console.WriteLine(book.Print);
        }
    }
}

