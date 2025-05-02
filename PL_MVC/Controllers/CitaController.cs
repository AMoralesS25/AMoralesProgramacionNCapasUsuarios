using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class CitaController : Controller
    {
        [HttpGet]
        public ActionResult GetAll()
        {

            return View();
        }
    }
}