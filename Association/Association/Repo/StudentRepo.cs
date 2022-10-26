using Association.DB;
using Association.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Association.Repo
{
    public class StudentRepo
    {
        public static List<StudentModel> Get() {
            var db = new UMS_fall22_aEntities();
            var students = new List<StudentModel>();
            foreach(var student in db.Students)
            {
                /*var studentModel = new StudentModel();
                studentModel.Id = student.Id;
                studentModel.Name = student.Name;
                students.Add(studentModel);*/
                students.Add(new StudentModel() {
                    Id = student.Id,
                    Name = student.Name,
                    DepartmentId = student.DepartmentId,
                    Dob = student.Dob,
                    StudentId = student.StudentId
                });
            }
            return students;
        }
        public static StudentModel Get(int id) {
            var db = new UMS_fall22_aEntities();
            var student = (from st in db.Students
                           where st.Id == id
                           select st).FirstOrDefault();
            var studentModel = new StudentModel();
            studentModel.Id = student.Id;
            studentModel.Name = student.Name;
            studentModel.DepartmentId = student.DepartmentId;
            studentModel.Dob = student.Dob;
            studentModel.StudentId = student.StudentId;
            return studentModel;

        }
        public static void Create(StudentModel st) {
            var student = new Student();
            student.Id = st.Id;
            student.DepartmentId = st.DepartmentId;
            student.StudentId = st.StudentId;
            student.Name = st.Name;
            student.Dob = st.Dob;
            var db = new UMS_fall22_aEntities();
            db.Students.Add(student);
            db.SaveChanges();

        }
    }
}