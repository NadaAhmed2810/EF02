
using EF02.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Data.Configurations
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            
                builder.ToTable("Department", "dbo")
                .HasKey(D => D.Id);


                builder.Property(D => D.Id)
                .UseIdentityColumn(10, 10);

                builder.Property(D => D.Name)
                        .HasColumnName("DepartmentName")
                        .HasColumnType(SQLServerDatatypes.varchar)
                        .HasAnnotation("MaxLength", 50);

                builder.Property(D => D.CreationDate)
                      // .HasDefaultValue(DateOnly.FromDateTime(DateTime.Now))//Time of Create Migration
                      //.HasDefaultValueSql("GETDATE()");
                      .HasComputedColumnSql("GETDATE()");
           
               builder.HasMany(D => D.Employees)
                      .WithOne(e => e.Department)
                    //.HasForeignKey("Department")
                      .IsRequired(false)
                      .OnDelete(DeleteBehavior.SetNull);

        }
    }
}
