using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    internal class CourseInstructor
    {
        public int InstructorId { get; set; }
        public Instructor instructor { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int Evaluate { get; set; }

    }
}
