using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models;

public class Adress
{
    public int Id { get; set; }
    public string location { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }
    
}
