using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Autofac.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using School.Models;
using School.Services;

namespace School.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentService _studentService;
        private readonly ICourseService _courseService;
        public HomeController(ILogger<HomeController> logger,IStudentService studentService,
            ICourseService courseService)
        {
            _logger = logger;
            _studentService = studentService;
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            ViewData.Model = _studentService.GetStudents(1,10);
            return View();
        }

        public IActionResult AddStudent()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddStudent(string Name, DateTime DateOfBirth)
        {
            Student student = new Student()
            {
                Name = Name,
                DateOfBirth = DateOfBirth
            };
            _studentService.AddStudent(student);
            return View();
        }

        public IActionResult Details(int Id)
        {
            var model =  _studentService.GetStudent(Id);
            return View(model);
        }

        public IActionResult EditStudent(int Id)
        {
            var model = _studentService.GetStudent(Id);
            ViewData["student"] = model;
            return View();
        }

        [HttpPost]
        public IActionResult EditStudent(int Id, string Name, DateTime DateOfBirth)
        {
            Student student = new Student()
            {
                Id = Id,
                Name = Name,
                DateOfBirth = DateOfBirth
            };
            _studentService.EditStudent(student);
            ViewData["student"] = student;
            return View();
        }

        public IActionResult Delete(int Id)
        { 
            _studentService.DeleteStudent(Id);
            return RedirectToAction("Index");
        }

        public IActionResult SearchCourse(string searchstring)
        {
            IList<Course> courses = _courseService.
                CourseSearchForUser(Int32.Parse(this.User.FindFirstValue(ClaimTypes.NameIdentifier)), searchstring);
            return Ok(courses);
        }

        public IActionResult AddCourses()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddCourses(CourseModel model)
        {
            Course course =  new Course()
            {
                Title = model.Title,
                Fee = model.Fee,
                SeatCount = model.SeatCount
            };
            _courseService.AddCourse(course);
            return View();
        }

        public IActionResult AllCourses()
        {
            var courses = _courseService.GetAllCourses();
            return View(courses);
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