using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_commerce.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int TotalSum { get; set; }
        public int OrderedBy { get; set; }
        public System.DateTime OrderDate { get; set; }

    }
}