using Assignment.Data;
using Assignment.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using ITIDbContext context = new ITIDbContext();

            #region Insert
            #region Course
            //var C01 = new Course() { Name = "Cs", Description = "Computer science",Duration="---" ,TopicId=1};
            //var C02 = new Course() { Name = "Db", Description = "DataBase",Duration="---" ,TopicId=2};
            //context.Add(C01);
            //context.Add(C02);
            //Console.WriteLine(context.Entry(C01).State);
            //Console.WriteLine(context.Entry(C02).State);
            //context.SaveChanges();
            #endregion
            #region Topic
            //var T01 = new Topic() { Name = "Cs" };
            //var T02 = new Topic() { Name = "Is"};
            //context.Add(T01);
            //context.Add(T02);
            //Console.WriteLine(context.Entry(T01).State);
            //Console.WriteLine(context.Entry(T02).State);
            //context.SaveChanges();
            #endregion
            #region Department
            //var D01 = new Department() { Name = "Cs",HiringDate=DateTime.Now };
            //var D02 = new Department() { Name = "Is",HiringDate=DateTime.Now };
            //context.Add(D01);
            //context.Add(D01);
            //Console.WriteLine(context.Entry(D01).State);
            //Console.WriteLine(context.Entry(D02).State);
            //context.SaveChanges();
            #endregion
            #region Student
            //var STD01 = new Student() { FName = "Nada",LName="Ahmed",Age=20,Address="Cairo",DetailedAddress=new Address() {BlockNumber=10,City="Cairo",Country="Egypt" },DepartmentId=1 };
            //var STD2 = new Student() { FName = "Nour", LName = "Hany", Age = 19,Address="Alex", DetailedAddress = new Address() { BlockNumber = 20, City = "Alex", Country = "Egypt" } ,DepartmentId=1};
            //context.Add(STD01);
            //context.Add(STD2);
            //Console.WriteLine(context.Entry(STD01).State);
            //Console.WriteLine(context.Entry(STD2).State);
            //context.SaveChanges();
            #endregion
            #endregion
            #region Select
            //var Department = (from E in context.Departments
            //                where E.Id == 1
            //                select E).AsNoTracking().FirstOrDefault();
            //if (Department != null)
            //{
            //    Console.WriteLine(context.Entry(Department).State);
            //    Console.WriteLine($"Name:{Department.Name},HiringDate:{Department.HiringDate}");
            //}

            //var student = (from E in context.Students
            //                  where E.Id == 5
            //                  select E).AsNoTracking().FirstOrDefault();
            //if (Department != null)
            //{
            //    Console.WriteLine(context.Entry(student).State);
            //    Console.WriteLine($"FName:{student.FName},LName:{student.LName}");
            //}
            #endregion
            #region Update
            //var Student = (from E in context.Students
            //               where E.Id == 6
            //                select E).FirstOrDefault();
            //if (Student != null)
            //{
            //    Console.WriteLine(context.Entry(Student).State);
            //    Student.FName = "Noura";
            //    Console.WriteLine(context.Entry(Student).State);//Modified
            //    context.SaveChanges();
            //    Console.WriteLine(context.Entry(Student).State);

            //    Console.WriteLine($"Name:{Student.FName},Age:{Student.Age}");
            //}
            #endregion
            #region delete
            //var Department = (from E in context.Departments
            //                  where E.Id == 1
            //                  select E).FirstOrDefault();
            //if (Department != null)
            //{
            //    context.Departments.Remove(Department);
            //    context.SaveChanges();
            //}

            //var student = (from E in context.Students
            //               where E.Id == 5
            //               select E).FirstOrDefault();
            //if (student != null)
            //{
            //    context.Students.Remove(student);
            //    context.SaveChanges();
            //}
            #endregion
        }
    }
}
