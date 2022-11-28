using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFCodeFirst.Models
{
    internal class User
    {
        [Key]
        [StringLength(50)]
        public string Username { get; set; }
        [StringLength(50)]
        [Required]
        public string Password { get; set; }
    }
}
