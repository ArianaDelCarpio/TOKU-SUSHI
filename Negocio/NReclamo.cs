using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NReclamo
    {
        private DReclamo dReclamo = new DReclamo();
        public String Registrar(Reclamo reclamo)
        {
            return dReclamo.Registrar(reclamo);
        }
        public List<Reclamo> ListarTodo()
        {
            return dReclamo.ListarTodo();
        }
        public List<Reclamo> ListarReclamosPorProducto(int idProducto)
        {
            return dReclamo.ListarReclamosPorProducto(idProducto);
        }
    }
}
