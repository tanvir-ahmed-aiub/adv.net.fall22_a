using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cgpa { get; set; }
        public int BLowerCount { get; set; }


        public int CurrCredit() { 
            Random random = new Random();
            return random.Next(13, 18);
        }

    }
}
