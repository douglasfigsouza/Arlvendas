using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Arlvendas.Models;

namespace Arlvendas.Controllers
{
    public class MecanicosController : Controller
    {
        private MecanicosRepository mecanicosRep;
        public MecanicosController()
        {
            this.mecanicosRep = new MecanicosRepository();
        }
        [HttpGet]
        public JsonResult getAllMecanicos()
        {
            return Json(mecanicosRep.getAllMecanicos().ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}