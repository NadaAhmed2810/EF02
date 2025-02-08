using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    internal class CourseInstructor
    {
        [ForeignKey(nameof(Models.Instructor.Id))]
        public int InstructorId { get; set; }

      
        public Instructor instructor { get; set; }



        [ForeignKey(nameof(Models.Course.Id))]

        public int CourseId { get; set; }
     
        public Course Course { get; set; }

        public int Evaluate { get; set; }

    }
}
