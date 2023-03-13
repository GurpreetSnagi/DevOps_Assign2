using Assignment2_531.Models;
using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;

namespace Assignment2_531.Controllers
{
    public class HomeController : Controller
    {
        private StudentContext context { get; set; }
        public HomeController(StudentContext ctx) =>
        context = ctx;

        public IActionResult Index()
        {
            var students = context.Students.OrderBy(m => m.FirstName).ToList();
            return View(students);
        }


    }
}