using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DevskillSystem.web.Models;
using DevskillSystem.web.Models.StudentModels;
using DevskillSystem.web.Models.SubjectModels;

namespace DevskillSystem.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new StudentModel();
            var students = model.GetAll();
            return View(students);
        }

        public IActionResult AddStudent()
        {
            var student = new StudentCreateModel();
            return View(student);
        }
        [HttpPost]
        public IActionResult AddStudent(StudentCreateModel student)
        {
            student.CreateStudent();
            return RedirectToAction("Index");
        }

        public IActionResult Subjects()
        {
            SubjectBaseModel model = new SubjectBaseModel();
            var subjects = model._subjectService.GetAllSubjects();
            return View(subjects);
        }

        [HttpPost]
        public IActionResult GradeInSubject(int studentId,int subjectId, double grade)
        {
            StudentModel model = new StudentModel();
            model._studentService.MarkGrade(studentId,subjectId,grade);
            return RedirectToAction("StudentDetails", new {id = studentId});
        }

        public IActionResult Subject(int Id)
        {
            return View();
        }

        public IActionResult DeleteSubject(int Id)
        {
            return RedirectToAction("Subjects");
        }

        public IActionResult AddSubject()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSubject(SubjectCreateModel subject)
        {
            subject.CreateSubject();
            return RedirectToAction("Subjects");
        }

        public IActionResult StudentDetails(int Id)
        {
            StudentModel studentmodel = new StudentModel();
            var model = studentmodel.Get(Id);
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}