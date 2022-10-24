using EFCoreCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

internal class Program
{
    static string _conectionString = string.Empty;


    private static void Main(string[] args)
    {
        var configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile($"appsetings.json");

        var config = configuration.Build();
        //_conectionString = config.GetConnectionString("Db1");

        var connectOpiton = new DbContextOptionsBuilder<BookContext>()
            .UseSqlServer(config.GetConnectionString("Db1"))
            .Options;


        using (var context = new BookContext(connectOpiton))
        {
            if (!context.Author.Where(e => e.FirstName == "J" && e.LastName == "Tolkin").Any())
            {
                Author Autor1 = new Author()
                {
                    FirstName = "J",
                    LastName = "Tolkin",
                    Books = new List<Book>()
                    {
                        new Book()
                        {
                            Title = "Herr der Ringe"
                        },
                        new Book()
                        {
                            Title = "Herr der Ringe 2"
                        }
                    }
                };

                Author Autor2 = new Author()
                {
                    FirstName = "David",
                    LastName = "Mangold",
                    Books = new List<Book>()
                {
                    new Book()
                    {
                        Title="Hallo"
                    },
                    new Book()
                    {
                        Title="Hallo2"
                    }
                }
                };

                context.Add(Autor2);
                context.SaveChanges();
            }
        }

        using (var context = new BookContext(connectOpiton))
        {
            foreach (var autor in context.Author.ToList())
            {
                Console.WriteLine($"{autor.LastName},{autor.FirstName},{autor.AuthorID} ");

                foreach (var book in context.Books.ToList())
                {
                    Console.WriteLine($"\t{book.BookID}, {book.Title}");
                }
            }
        }

    }
}