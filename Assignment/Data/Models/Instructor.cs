using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Bouns {  get; set; }
        public decimal Salary { get; set; }
        public string Address {  get; set; }
        public decimal HourRate {  get; set; }

        public Address DetailedAddress { get; set; } = null!;

        [ForeignKey(nameof(Models.Department.Id))]
        public int DepartmentId { get; set; }

        [InverseProperty(nameof(Models.Department.Instructor))]
        public Department Department { get; set; }

        public ICollection<CourseInstructor> CourseInstructors { get; set; }

    }
}
