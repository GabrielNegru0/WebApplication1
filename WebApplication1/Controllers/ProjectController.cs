using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult DoAnAction()
        {
            return Content("Hello World");
        }


        public ActionResult HelloUser(String alpha)
        {
            return Content("Hello:"+ alpha);
        }
    }

    
}