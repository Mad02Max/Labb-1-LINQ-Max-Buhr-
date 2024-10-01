using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SUT_23_Labb_1_LINQ.Data;
using SUT_23_Labb_1_LINQ.Models;
using System.Runtime.CompilerServices;

using (var dbContext = new AppDbContext())
{
    var teacher1 = new Teacher { Name = "Anas" };
    var teacher2 = new Teacher { Name = "Reidar" };

    var subject1 = new Subject { Name = "Matte" };
    var subject2 = new Subject { Name = "Programmering2" };

    var student1 = new Student { Name = "Student1", teacher = teacher1 };
    var student2 = new Student { Name = "Student2", Teacher = teacher1 };

    var course1 = new Course { Name = "SUT23" };

    teacher1.Courses.Add(course1);
    teacher2.Courses.Add(course1);

    student1.Subjects.Add(subject1);
    student2.Subjects.Add(subject2);

    dbContext.Teachers.Add(teacher1);
    dbContext.Teachers.Add(teacher2);

    dbContext.Subjects.Add(subject1);
    dbContext.Subjects.Add(subject2);

    dbContext.Students.Add(student1);
    dbContext.Students.Add(student2);

    dbContext.Courses.Add(course1);

    dbContext.SaveChanges();
}
namespace SUT_23_Labb_1_LINQ
{
    internal class Program
    {
        private readonly AppDbContext _context;
        
        public Program()
        {
            _context = new AppDbContext();
        }

        static void Main(string[] args)
        {
            var context = new Program();
            context.AddToDB();
            context.Run();
        }

        public void AddToDB()
        {
            var teacher1 = new Teacher { Name = "Anas" };
            var teacher2 = new Teacher { Name = "Reidar" };

            var subject1 = new Subject { Name = "Matte" };
            var subject2 = new Subject { Name = "Programmering1" };

            var student1 = new Student { Name = "Student1", teacher = teacher1 };
            var student2 = new Student { Name = "Student2", Teacher = teacher2 };

            var course1 = new Course { Name = "SUT23" };

            teacher1.Courses.Add(course1);
            teacher2.Courses.Add(course1);

            student1.Subjects.Add(subject1);
            student2.Subjects.Add(subject2);

            _context.Teachers.Add(teacher1);
            _context.Teachers.Add(teacher2);

            _context.Subjects.Add(subject1);
            _context.Subjects.Add(subject2);

            _context.Students.Add(student1);
            _context.Students.Add(student2);
            _context.Courses.Add(course1);
                
            _context.SaveChanges();
        }

        public void Run()
        {

        }
    }
}
