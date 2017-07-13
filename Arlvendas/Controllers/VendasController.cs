using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Arlvendas.Controllers
{
    public class VendasController : Controller
    {
        // GET: Vendas
        public ActionResult addVendas()
        {
            return View();
        }
    }
}