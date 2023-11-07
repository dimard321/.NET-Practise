using AspNetExampleDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetExamleDataLayer.Configurations
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c=> c.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.Capacity)
                .IsRequired();

            builder.HasMany(c => c.Students)
                .WithMany(s => s.Courses);

        }
    }
}
