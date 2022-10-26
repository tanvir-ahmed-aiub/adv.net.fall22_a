using Association.DB;
using Association.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Association.Repo
{
    public class DepartmentRepo
    {
        public static List<DepartmentModel> Get()
        {
            var db = new UMS_fall22_aEntities();
            var depts = new List<DepartmentModel>();
            foreach (var dp in db.Departments)
            {
                /*var studentModel = new StudentModel();
                studentModel.Id = student.Id;
                studentModel.Name = student.Name;
                students.Add(studentModel);*/
                depts.Add(new DepartmentModel()
                {
                    Id = dp.Id,
                    Name = dp.Name,
                    
                });
            }
            return depts;
        }
    }
}