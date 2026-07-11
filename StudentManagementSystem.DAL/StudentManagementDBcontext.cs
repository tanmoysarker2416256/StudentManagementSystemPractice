using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.DAL; 

public class StudentManagementDBcontext : DbContext
{
    public StudentManagementDBcontext(DbContextOptions<StudentManagementDBcontext> options) : base(options) { } 

    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Adress> Adresses { get; set; }

    public DbSet<Customer>Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new Configuration.StudentConfiguration());

       modelBuilder.ApplyConfiguration(new Configuration.CourseConfiguration());

      
     
    }
 
}
