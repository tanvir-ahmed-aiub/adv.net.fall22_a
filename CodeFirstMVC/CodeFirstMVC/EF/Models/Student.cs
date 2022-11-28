using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstMVC.EF.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float? Cgpa { get; set; }
        [ForeignKey("Department")]
        public int? DeptId { get; set; }
        public virtual Department Department { get; set; }
    }
}