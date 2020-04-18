using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using School.Models;
using School.Services;

namespace School.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentModel _studentModel;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentModel = new StudentModel();
        }

        public IActionResult Index()
        {
            ViewData.Model = _studentModel.GetStudents(1,10);
            return View();
        }

        public IActionResult AddStudent()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddStudent(string Name, DateTime DateOfBirth)
        {
            _studentModel.CreateStudent(Name,DateOfBirth);
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