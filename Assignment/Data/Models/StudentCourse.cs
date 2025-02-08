using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    internal class StudentCourse
    {
        [ForeignKey(nameof(Models.Student.Id))]

        public int StudentId { get; set; }
        public Student Student { get; set; }

        [ForeignKey(nameof(Models.Course.Id))]

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int Grade { get; set; }

    }
}
