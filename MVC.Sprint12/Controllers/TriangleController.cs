using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Sprint12.Controllers
{
    public class TriangleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}