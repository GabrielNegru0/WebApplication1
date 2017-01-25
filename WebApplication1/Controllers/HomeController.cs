using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var model = new AboutModel();
            model.Message = "Hello";
            model.Author = "GABRIEL";
           // ViewBag.Author = "Gabriel Negru";
            //ViewBag.Message = "Your application description page.";
            
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public double Average()
        {
            int sum = 0;
            var lista = new List < int > { 1,3,7};
            foreach(int x in lista)
            {
                sum += x;
            }
            return sum/lista.Count;

            //double x = lista.Average();

            //return x;
        }

        public ActionResult HelloWorld()
        {
            return Content("HelloWorld");
        }
    }
}