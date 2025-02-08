
using EF02.Data;
using EF02.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace EF02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext context = new CompanyDbContext();
            #region Insert
            ///Employee E01= new Employee() {Name="Ahmed",Age=26,Salary=8000,/*Email="ahmed"*/ Email="ahmed@gmail.com",Address="Alex",Phone="555" };
            ///Employee E02 = new Employee() { Name = "Nadia", Age = 20, Salary = 5000, Email = "Nadia@gmail.com",Phone="333" };
            /// //Email not throw exception ? Data notation not work in Console Application but in Web or Desktop 
            ///Console.WriteLine(context.Entry(E01).State);//Detached
            /// //Console.WriteLine(context.Entry(E02).State);
            ///  //context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            ///context.Employees.Add(E01);
            ///context.Employees.Add(E02);
            /// //context.Set<Employee>().Add(E01);
            /// //context.Add(E01);
            /// //context.Entry(E01).State=EntityState.Added;
            ///Console.WriteLine(context.Entry(E01).State);//Added
            ///context.SaveChanges();
            ///Console.WriteLine(context.Entry(E01).State);//unchanged
            ///Console.WriteLine(E01.Code);
            ///Console.WriteLine(E02.Code);

            #endregion

            #region Select

            //var employee = (from E in context.Employees
            //                where E.Code == 6
            //                select E).AsNoTracking().FirstOrDefault();
            //if (employee != null)
            //{
            //    Console.WriteLine(context.Entry(employee).State);
            //    Console.WriteLine($"Name:{employee.Name},Age:{employee.Age},Email={employee.Email},Phone:{employee.Phone}");
            //}
            #endregion

            #region Update
            //var employee = (from E in context.Employees
            //                where E.Code == 6
            //                select E).FirstOrDefault();
            //if (employee != null)
            //{
            //    Console.WriteLine(context.Entry(employee).State);//unchanged
            //    employee.Name = "Hamda";
            //    Console.WriteLine(context.Entry(employee).State);//Modified
            //    context.SaveChanges();
            //    Console.WriteLine(context.Entry(employee).State);//unChanged

            //    Console.WriteLine($"Name:{employee.Name},Age:{employee.Age},Email={employee.Email},Phone:{employee.Phone}");
            //}
            #endregion
            #region Delete
            //var employee = (from E in context.Employees
            //                where E.Code == 7
            //                select E).FirstOrDefault();
            //if (employee != null)
            //{
            //    Console.WriteLine(context.Entry(employee).State);//unchanged
            //    context.Employees.Remove(employee);
            //    //context.Set<Employee>().Remove(employee);
            //    //context.Remove(employee);
            //    //context.Entry(employee).State = EntityState.Deleted;

            //    Console.WriteLine(context.Entry(employee).State);//Deleted
            //    context.SaveChanges();
            //    Console.WriteLine(context.Entry(employee).State);//Detached 

            //    Console.WriteLine($"Name:{employee.Name},Age:{employee.Age},Email={employee.Email},Phone:{employee.Phone}");
            // }
            #endregion







        }
    }
}
