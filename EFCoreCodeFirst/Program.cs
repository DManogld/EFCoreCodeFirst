using EFCoreCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System;
using System.Security.Cryptography;
using Microsoft.VisualBasic;
using System.Collections.Generic;

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

            context.Add(Autor1);
            context.SaveChanges();

        }
    }
}