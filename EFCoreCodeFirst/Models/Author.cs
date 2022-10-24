using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Models
{
    internal class Author
    {
        public Author()
        {
          
        }
        
        public int AuthorID{ get; set; }
        public ICollection<Book> Books { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
