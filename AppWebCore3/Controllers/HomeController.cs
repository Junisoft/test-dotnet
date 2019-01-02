using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppWebCore3.Models;

namespace AppWebCore3.Controllers
{
    public class HomeController : Controller
    {
        private DataContext db = new DataContext();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        //[Route("")]
        public IActionResult Empleados()
        {        
            ViewBag.Empleados = db.Empleados.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add", new Empleados());
        }

        [HttpPost]
        public IActionResult Add(Empleados emp)
        {
            db.Add(emp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
