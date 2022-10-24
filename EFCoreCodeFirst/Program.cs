using EFCoreCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        Insert();
    }

    private static void Insert()
    {
        
        using (var context = new BookContext())
        {
            Author Autor1 = new Author();
            Autor1.AuthorID = 1;
            Autor1.FirstName = "J";
            Autor1.LastName = "Tolkin";

            List<Book> books = new List<Book>();

            Book book1 = new Book();
            book1.AuthorID = 1;
            book1.Autor= Autor1;
            book1.BookID = 1;
            book1.Title = "Herr der Ringe 1";

            Book book2 = new Book();
            book2.AuthorID = 1;
            book2.Autor = Autor1;
            book2.BookID = 2;
            book2.Title = "Herr der Ringe 2";

            books.Add(book1);
            books.Add(book2);
            ICollection<Book> bookCollection = books;

            Autor1.Books = bookCollection;


            //context.Add(books);

            context.Add(Autor1);
            context.SaveChanges();

        }
    }
}