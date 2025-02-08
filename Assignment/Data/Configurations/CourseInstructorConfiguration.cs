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
    internal class CourseInstructorConfiguration : IEntityTypeConfiguration<CourseInstructor>
    {
        public void Configure(EntityTypeBuilder<CourseInstructor> builder)
        {
            builder.HasKey(cs => new {cs.CourseId,cs.InstructorId });
            //connect in side Course
            builder.HasOne(cs => cs.Course)
             .WithMany(c => c.CourseInstructors)
             .HasForeignKey(cs => cs.CourseId);

            //connect in side Instructor
            builder.HasOne(cs => cs.instructor)
           .WithMany(Ins => Ins.CourseInstructors)
           .HasForeignKey(cs => cs.InstructorId);
        }
    }
}
