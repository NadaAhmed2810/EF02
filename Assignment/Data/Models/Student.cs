using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; } = null!;
        public string LName { get; set; } = null!;
        public string Address {  get; set; }
        public int Age {  get; set; }
        public Address DetailedAddress { get; set; } = null!;
        public ICollection<StudentCourse> StudentCourses { get; set; }


        [ForeignKey(nameof(Models.Department.Id))]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

    }
}
