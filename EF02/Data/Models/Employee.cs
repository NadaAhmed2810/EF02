using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Data.Models
{
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Code { get; set; }//Public Numeric Property Named  as Id or "ClassNameId" Will Be Considered Primary Key[Identity(1,1) ]
        [Column(TypeName = "varchar")]
        [StringLength(50, MinimumLength = 10)]
        //[MaxLength(50)]
        //[MinLength(10)]
        //[Length(10,50)]


        public /*required*/  string? Name { get; set; }//Nullable Reference Type  [Allow Null ][Optional]
        [Column(TypeName = "decimal(12,2)")]
        [DataType(DataType.Currency)]
        public double Salary { get; set; }//Non _Nullable Value Type :Not allow Null [Required]
        [Range(22, 60)]
        //[AllowedValues(20,40,60,50)]
        //[DeniedValues(10,15)]
        public int? Age { get; set; }//Nullable Value Type :Not allow Null [Optional]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Phone]
        [Required(ErrorMessage = "Phone is Required!!")]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }
        [RegularExpression("")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        //Derived Attribute 
        [NotMapped]
        public double NetSalary => Salary - Salary * .2;
        //public double GetNetSalary=> Salary - Salary * .2;
        public string Address { get; set; }

        public Address DetailedAddress { get; set; } = null!;





        [ForeignKey(nameof(Department))]
        public int? DepartmentId { get; set; }//foreign Key for Table Department [Work]




        //Navigational Property [one]
        [InverseProperty(nameof(Models.Department.Employees))]
        public Department? Department { get; set; }

        //Navigational property [one]
        [InverseProperty(nameof (Models.Department.Manager))]
        public Department? ManagedDepartment { get; set; }


        
    }
}
