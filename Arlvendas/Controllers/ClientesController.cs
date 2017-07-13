using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Arlvendas.Models;

namespace Arlvendas.Controllers
{
    public class ClientesController : Controller
    {
        private ClientesRepository clientesRep;
        public ClientesController()
        {
            this.clientesRep = new ClientesRepository();
        }

        public ActionResult addClientes()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addClientes(CLIENTES cliente)
        {
            clientesRep.addClientes(cliente);
            return RedirectToAction("addVendas","Vendas");
        }
        [HttpGet]
        public JsonResult getAllClientes()
        {
            return Json(clientesRep.getAllClientes().ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}