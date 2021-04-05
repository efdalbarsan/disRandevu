using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DentistCalendar.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            //rol
            return View("Secretary");
        }

        public IActionResult Secretary()
        {
            return View();
        }

        public IActionResult Dentist()
        {
            return View();
        }
    }
}