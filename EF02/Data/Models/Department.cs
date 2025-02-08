using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Data.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public DateOnly CreationDate { get; set; }

        //Navigational Property [Many]
        [InverseProperty(nameof(Models.Employee.Department))]
        public ICollection<Employee> Employees { get; set; }=new HashSet<Employee>();

        [ForeignKey(nameof(Manager))]
        public int? ManagerId {  get; set; } 

        //Navigational Property[One]
        [InverseProperty(nameof(Models.Employee.ManagedDepartment))]
        //[ForeignKey(nameof(ManagerId))]
        public Employee Manager { get; set; }
       
    }
}
