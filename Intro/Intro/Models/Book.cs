using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Intro.Models
{
    public class Book
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Author { get; set; }
        public int Edition { get; set; }

    }
}