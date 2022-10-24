using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EFCoreCodeFirst.Models
{
    internal class Book
    {

        
        public int BookID { get; set; }
        public int AuthorID { get; set; }
        public Author Autor { get; set; }
        public string Title { get; set; }
    }
}
