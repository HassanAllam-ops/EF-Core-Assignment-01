using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Core_Assignment_01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Core_Assignment_01.ConfigutationClasses
{
    internal class CourseInstructorConfigurations : IEntityTypeConfiguration<CourseInstructor>
    {
        public void Configure(EntityTypeBuilder<CourseInstructor> builder)
        {
            builder.HasKey(ci => new { ci.CourseId, ci.InstractorId });
            builder.Property(ci => ci.Evaluate)
                .IsRequired()
                .HasDefaultValue(0);
        }
    }
}
