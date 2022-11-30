using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int? PostedBy { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public Post() {
            Comments = new List<Comment>();
        }

    }
}
