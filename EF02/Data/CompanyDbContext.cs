using Common1;
using EF02.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Data
{
    static class SQLServerDatatypes
    {
        public static string varchar => "varchar";

    }
    internal class CompanyDbContext:DbContext
    {
       public CompanyDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Company;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent APIs for each and every Model
            #region Employee
            modelBuilder.Entity<Employee>()
                        .Property<string>("Address")
                        //.Property(nameof(Employee.Age));
                        //.Property(E => E.Age);
                        .HasDefaultValue("Cairo")
                        .HasColumnType(SQLServerDatatypes.varchar)
                        .HasMaxLength(50)
                        .IsRequired();
            #endregion




            modelBuilder.Entity<Department>(E =>
            {

                E.ToTable("Department", "dbo")
                .HasKey(D => D.Id);


                E.Property(D => D.Id)
                .UseIdentityColumn(10, 10);

                E.Property(D => D.Name)
                        .HasColumnName("DepartmentName")
                        .HasColumnType(SQLServerDatatypes.varchar)
                        .HasAnnotation("MaxLength", 50);

                E.Property(D => D.CreationDate)
                      // .HasDefaultValue(DateOnly.FromDateTime(DateTime.Now))//Time of Create Migration
                      //.HasDefaultValueSql("GETDATE()");
                      .HasComputedColumnSql("GETDATE()");
            });//Ef Core 3.1 NEW Feature


        }
        DbSet<Employee> Employees { get; set; }
       DbSet<Department> Departments { get; set; }
    }
}
