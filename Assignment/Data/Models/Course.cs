using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; }
        public string Duration {  get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
        public ICollection<CourseInstructor> CourseInstructors { get; set; }

        [ForeignKey(nameof(Models.Topic.Id))]
        public int TopicId { get; set; }

        [InverseProperty(nameof(Models.Topic.Courses))]
        public Topic Topic { get; set; } = null!;

    }
}
