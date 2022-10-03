using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static Random rand = new Random();
        static double RandCgpa(double min, double max){
            return (rand.NextDouble() * (max - min) + min);
        }
        static List<Student> GetStudents() { 
            var students = new List<Student>(); 
            for(int i = 1; i <= 100; i++)
            {
                
                students.Add(new Student() {
                    Id = i,
                    Name = "Student " + i,
                    Cgpa = RandCgpa(2.00,4.00),
                    BLowerCount = rand.Next(0,6)
                }) ;
            }
            return students;
        }

        static void PrintList(List<Student> students)
        {
            foreach (var st in students)
            {
                Console.WriteLine("Name: {0}, Cgpa: {1}, LowerB: {2}", st.Name, st.Cgpa,st.BLowerCount);
            }
        }
        static void Main(string[] args)
        {

            var students = GetStudents();
            PrintList(students);
            Console.WriteLine("----------------All-------------");
            Console.WriteLine("----------------Probation-------------");
            var probations = (from st in students where st.Cgpa<2.5 select st).ToList();
            PrintList(probations);
            Console.WriteLine("----------------Scholarships-------------");
            var scholarships = (from st in students where 
                                st.Cgpa >= 3.75 &&
                                st.BLowerCount == 0 &&
                                st.CurrCredit() >=14
                                select st).ToList();
            PrintList(scholarships);
            //int[] numbers = new int[] {2,3,56,45,34,23,56,78,80,85,87,89,90 };


            //for (int i = 0; i < numbers.Length; i++) {
            //    if (numbers[i]>= 70) {
            //        filtered[count++] = numbers[i];
            //        //Console.Write(numbers[i] + " ");
            //    }
            //}

            //var filtered = (from num in numbers
            //               where num >= 70
            //               select num).ToArray();
            //for (int i = 0; i < filtered.Length; i++) {
            //    Console.Write(filtered[i] + " ");
            //}






        }
    }
}
