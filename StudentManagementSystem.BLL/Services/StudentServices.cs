using StudentManagementSystem.DAL.Repository;
using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.BLL.Services; 

public class StudentServices
{
    private readonly StudentRepository  _studentRepository;
    public StudentServices(StudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public IEnumerable<Student> GetAllStudents()
    { 
        return _studentRepository.GetStudents();
    }

    public void AddStudent(Student students)
    {
        _studentRepository.AddStudent(students);
    }
    public Student GetStudent(int id)
    {
        return _studentRepository.GetStudent(id);
    }
    public void DeleteStudent(int id)
    {
        _studentRepository.DeleteStudent(id);
    }
    public void UpdateStudent(Student student)
    {
        _studentRepository.UpdateStudent(student);
    }
}
