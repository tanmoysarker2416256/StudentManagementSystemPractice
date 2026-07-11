using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.BLL.Services;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Web.Controllers; 

public class StudentController : Controller
{

    private readonly StudentServices _studentServices;
    public StudentController(StudentServices studentServices)
    {
        _studentServices = studentServices;
    }
    public IActionResult Index()
    {
        var Students = _studentServices.GetAllStudents();
        return View(Students);
    }
    public IActionResult Create()
    {
       
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Student students)
    {
        if (ModelState.IsValid)
        {
            _studentServices.AddStudent(students);
            return RedirectToAction("Index");
        }

        return View();
    }

    public IActionResult Details(int id )
    {
        var students = _studentServices.GetStudent(id);
        return View(students);
    }

    public IActionResult Delete(int id)
    {
        var student = _studentServices.GetStudent(id);
        return View(student);
    }

    [HttpPost]
    [ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        _studentServices.DeleteStudent(id);
        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        var student = _studentServices.GetStudent(id);
        return View(student);
    }
    [HttpPost]
    public IActionResult Edit(Student student)
    {
        _studentServices.UpdateStudent(student);
        return RedirectToAction("Index");
    }
}
