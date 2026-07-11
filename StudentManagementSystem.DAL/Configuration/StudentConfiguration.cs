using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.DAL.Configuration;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable("Student");
        builder.HasKey(s=>s.Id);
        builder.Property(s => s.Name)
            .IsRequired()
            .HasMaxLength(50);



        builder.HasMany(s => s.Courses)
               .WithMany(s => s.Students)
               .UsingEntity(s => s.ToTable("StudentCourses"));



    }
}
    