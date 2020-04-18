using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
        private readonly IStudentService _service;
        public HomeController(ILogger<HomeController> logger,IStudentService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            ViewData.Model = _service.GetStudents(1,10);
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
            _service.AddStudent(student);
            return View();
        }

        public IActionResult Details(int Id)
        {
            var model =  _service.GetStudent(Id);
            return View(model);
        }

        public IActionResult EditStudent(int Id)
        {
            var model = _service.GetStudent(Id);
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
            _service.EditStudent(student);
            ViewData["student"] = student;
            return View();
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