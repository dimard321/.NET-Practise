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
    public class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name).IsRequired().HasMaxLength(30);

            builder.Property(s => s.Surname).IsRequired().HasMaxLength(30);

            builder.Property(s => s.Age).IsRequired();

            builder.Property(s => s.Gender).IsRequired();

        }
    }
}
