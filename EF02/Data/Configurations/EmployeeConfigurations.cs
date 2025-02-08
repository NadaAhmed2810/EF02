using EF02.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Data.Configurations
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Employee> builder)
        {
            builder
                     .Property<string>("Address")
                     //.Property(nameof(Employee.Age));
                     //.Property(E => E.Age);
                     .HasDefaultValue("Cairo")
                     .HasColumnType(SQLServerDatatypes.varchar)
                     .HasMaxLength(50)
                     .IsRequired();

           builder
                       .HasOne(E => E.ManagedDepartment)
                       .WithOne(D => D.Manager)
                       .IsRequired(false)
                       .HasForeignKey<Department>(D => D.ManagerId)
                       .OnDelete(DeleteBehavior.SetNull);
            builder.OwnsOne(E => E.DetailedAddress,Address=>Address.WithOwner());
        }
    }
}
