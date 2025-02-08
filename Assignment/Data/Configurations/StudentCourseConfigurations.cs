using Assignment.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Configurations
{
    internal class StudentCourseConfigurations : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
           builder.HasKey(cs => new { cs.CourseId, cs.StudentId });
            //connect in side Course
           builder.HasOne(cs => cs.Course)
            .WithMany(c => c.StudentCourses)
            .HasForeignKey(cs => cs.CourseId);

            //connect in side Student
            builder.HasOne(cs => cs.Student)
           .WithMany(c => c.StudentCourses)
           .HasForeignKey(cs => cs.StudentId);
        }
    }
}
