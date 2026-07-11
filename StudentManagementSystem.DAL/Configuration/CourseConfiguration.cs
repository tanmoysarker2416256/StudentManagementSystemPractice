using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.DAL.Configuration;

public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.HasKey(c=>c.Id);
        builder.Property(c=>c.Id)
            .IsRequired();
        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(50);
        builder.Property(c => c.Code)
                   .IsRequired()
                   .HasMaxLength(50);
    }
}
