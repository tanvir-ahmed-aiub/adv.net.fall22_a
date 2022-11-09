using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationConsoleLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = StudentService.Get();
            foreach (var item in data)
            {
                Console.WriteLine("Id : {0}, Name: {1}", item.Id, item.Name);
            }
        }
    }
}
