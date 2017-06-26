using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APP_MVC_TEST_WCF.ReferenciaNegocios;

namespace APP_MVC_TEST_WCF.Controllers
{
    public class NegociosController : Controller
    {
        ServiceNegociosClient proxi = new ServiceNegociosClient();

        // GET: Negocios
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Clientes()
        {
            return View(proxi.Clientes());
        }

        public ActionResult ClientesPorNombre(String nombre)
        {
            ViewBag.nombre = nombre;
            return View(proxi.ClientesPorNombre(nombre));
        }
    }
}