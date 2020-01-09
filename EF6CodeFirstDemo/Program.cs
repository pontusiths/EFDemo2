using System;
using System.Linq;

namespace EF6CodeFirstDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var schoolContext = new SchoolContext();
            var student = new Student { StudentName = "Hans", Height = 180, Weight = 9999 };
            schoolContext.SaveChanges();
            var hans = schoolContext.Students.Single(s => s.StudentName == "Hans");
            hans.Courses.Add(new Course { CourseName=".NET" });
            schoolContext.SaveChanges();
        }
    }
}