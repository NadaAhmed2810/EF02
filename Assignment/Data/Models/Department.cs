using System;
using System.Collections.Generic;
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
      



        public int InstructorId { get; set; }
        public ICollection<Instructor> Instructor { get; set; } = new HashSet<Instructor>();
    }
}
