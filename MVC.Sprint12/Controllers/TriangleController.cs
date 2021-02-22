using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using static MVC.Sprint12.Controllers.TriangleController;

namespace MVC.Sprint12.Controllers
{
    public class TriangleController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Info(Triangle triangle)
        {
            ViewBag.Side1 = triangle.Side1;
            ViewBag.Side2 = triangle.Side2;
            ViewBag.Side3 = triangle.Side3;
            ViewBag.Side1Perimetr = triangle.Side1 / triangle.GetPerimeter();
            ViewBag.Side2Perimetr = triangle.Side2 / triangle.GetPerimeter();
            ViewBag.Side3Perimetr = triangle.Side3 / triangle.GetPerimeter();
            ViewBag.Area = triangle.GetArea();
            ViewBag.Perimetr = triangle.GetPerimeter();

            return View();
                       
                
        }


      
        public class Triangle
        {
            public double Side1 { get; set; }
            public double Side2 { get; set; }
            public double Side3 { get; set; }
            public double GetArea()
            {
                double p = (Side1 + Side2 + Side3)/2;
                double s = Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
                return s;
            }

            public double GetPerimeter()
            {
                return Side1 + Side2 + Side3;
            }
        }
    }
}