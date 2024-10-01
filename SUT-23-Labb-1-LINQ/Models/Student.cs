using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT_23_Labb_1_LINQ.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public Teacher teacher { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public Teacher Teacher { get; set; }
    }
}
