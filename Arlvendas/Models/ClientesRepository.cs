using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Arlvendas.Models
{
    public class ClientesRepository
    {
        private GesArlDb context;
        public ClientesRepository()
        {
            this.context = new GesArlDb();
        }
        public void addClientes(CLIENTES cliente)
        {
            context.CLIENTES.Add(cliente);
            try
            {
                context.SaveChanges();
            }
            catch
            {
                throw;
            }

        }
        public List<CLIENTES> getAllClientes()
        {
            var consulta = context.CLIENTES.AsEnumerable();
            return consulta.ToList();
        }
    }
}