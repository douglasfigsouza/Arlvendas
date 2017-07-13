using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Arlvendas.Models;

namespace Arlvendas.Models
{
    public class MecanicosRepository
    {
        private GesArlDb context;
        public MecanicosRepository()
        {
            this.context = new GesArlDb();
        }
        public List<MECANICOS> getAllMecanicos()
        {
            var consulta = context.MECANICOS.AsEnumerable();
            return consulta.ToList();
        }
    }
}