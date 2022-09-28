using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Intro.Models
{
    public class Book
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please provide title")]
        [StringLength(50,ErrorMessage ="Title must not exceed 50")]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public int Edition { get; set; }
        [Required]
        public string Password { get; set; }
        
        [Compare("Password")]
        public string ConfPassword { get; set; }

    }
}