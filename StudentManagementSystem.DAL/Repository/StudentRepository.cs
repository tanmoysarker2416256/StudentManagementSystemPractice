using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.DAL.Repository; 

public class StudentRepository
{

    private readonly StudentManagementDBcontext _dbcontext;

    public StudentRepository(StudentManagementDBcontext dbcontext)
    {
        _dbcontext = dbcontext;
    }

    public IEnumerable<Student> GetStudents()
    {
       

        return _dbcontext.Students.ToList();
    }

    public void AddStudent(Student students)
    {
        _dbcontext.Students.Add(students);
        _dbcontext.SaveChanges();
    }

    public Student GetStudent(int id)
    {
        return _dbcontext.Students.FirstOrDefault(x => x.Id==id);
    }

    public void DeleteStudent(int id)
    {
        var student = _dbcontext.Students.Find(id);
        if (student!=null)
        {
            _dbcontext.Students.Remove(student);
            _dbcontext.SaveChanges();
        }
    }

    public void UpdateStudent(Student student)
    {
        _dbcontext.Students.Update(student);
        _dbcontext.SaveChanges();
    }
    
}
