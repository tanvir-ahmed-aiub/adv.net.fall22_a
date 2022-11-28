namespace CodeFirstMVC.Migrations
{
    using CodeFirstMVC.EF.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstMVC.EF.UMSDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirstMVC.EF.UMSDBContext context)
        {
            List<Department> depts = new List<Department>();
            List<Student> students = new List<Student>();
            for(int i = 1; i <= 1000; i++)
            {
                depts.Add(new Department() { 
                      DeptId= i,
                      Name = Guid.NewGuid().ToString().Substring(0,4),
                });
            }
            Random rand = new Random();
            for (int i = 1; i <= 1000; i++)
            {
                
                students.Add(new Student()
                {
                   // Id = i,
                    Name = Guid.NewGuid().ToString().Substring(0, 10),
                    DeptId =rand.Next(1,1000),
                });
            }
            context.Departments.AddOrUpdate(depts.ToArray());
            context.Students.AddOrUpdate(students.ToArray());   
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
