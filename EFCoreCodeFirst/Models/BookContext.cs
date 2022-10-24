using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreCodeFirst.Models;

namespace EFCoreCodeFirst.Models
{
    internal class BookContext:DbContext
    {
        public BookContext()
        {

        }
        public BookContext(DbContextOptions<BookContext>options)
            : base(options) 
        {

        } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=DESKTOP-DLNDEC4;Initial Catalog=EFCoreCodeFirst;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Author { get; set; }
    }
}
