using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroUIPrueba2.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Crear()
        {
            return View();
        }
        public ActionResult Inventario()
        {
            return View();
        }
        public ActionResult Closets()
        {
            return View();
        }
        public ActionResult ClosetsCR()
        {
            return View();
        }
        public ActionResult Comedores()
        {
            return View();
        }
        public ActionResult Comodas()
        {
            return View();
        }
        public ActionResult ComodasCR()
        {
            return View();
        }
        public ActionResult Camas()
        {
            return View();
        }
    }
}