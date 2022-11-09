using BLL.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentService
    {
        public static List<StudentDTO> Get() {
            var students = new List<StudentDTO>();
            foreach (var item in StudentRepo.Get())
            {

                students.Add(new StudentDTO() { Id = item.Id, Name=item.Name });
            }
            return students;
        }
    }
}
