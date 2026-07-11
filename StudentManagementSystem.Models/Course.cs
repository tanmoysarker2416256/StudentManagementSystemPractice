using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models; 

public class Course
{
    public int Id { get; set; } 
    public string Code { get; set; }
    public string Name { get; set; }

    public List<Student> Students { get; set; }
}
