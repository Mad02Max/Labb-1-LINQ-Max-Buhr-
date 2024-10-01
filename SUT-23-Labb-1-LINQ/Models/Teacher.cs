using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT_23_Labb_1_LINQ.Models
{
    internal class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
