using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT_23_Labb_1_LINQ.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Subject> Subjects { get; set; }
    }
}
