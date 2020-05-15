using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DevskillSystem.web.Models;
using DevskillSystem.web.Models.TransactionModels;

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
            var model = new TransModel();
            var transactions = model.GetAll();
            return View(transactions);
        }

        public IActionResult AddTrans()
        {
            var trans = new TransCreateModel();
            return View(trans);
        }
        [HttpPost]
        public IActionResult AddTrans(TransCreateModel model)
        {
            model.Create();
            return RedirectToAction("Index");
        }

        public IActionResult EditTrans(int Id)
        {
            var trans =new TransEditModel(Id);
            return View(trans);
        }

        [HttpPost]
        public IActionResult EditTrans(TransEditModel trans)
        {
            trans.Edit();
            return View();
        }
        public IActionResult Delete(int Id)
        {
            var model = new TransModel();
            model.Delete(Id);
            return RedirectToAction("Index");
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