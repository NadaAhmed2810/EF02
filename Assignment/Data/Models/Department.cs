using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime HiringDate { get; set; }



        [ForeignKey(nameof(Models.Instructor.Id))]
        public int InstructorId { get; set; }
        [InverseProperty(nameof(Models.Instructor.Department))]
        public ICollection<Instructor> Instructor { get; set; } = new HashSet<Instructor>();
    }
}
