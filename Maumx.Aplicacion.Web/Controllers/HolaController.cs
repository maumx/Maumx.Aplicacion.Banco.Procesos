using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Maumx.Aplicacion.Web.Controllers
{
    public class HolaController : Controller
    {
        // GET: Hola
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Mundo()
        {
            ViewBag.Loquequiera = "Hola Mundo desde ViewBag";
            
            return View();
        }
    }
}