using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NAgente
    {
        private DAgente dAgente = new DAgente();
        public List<Agente> ListarTodo()
        {
            return dAgente.ListarTodo();
        }
        public List<CantidadDeReclamosPorAgente> ListarCantidadDeReclamosPorAgente()
        {
            return dAgente.ListarCantidadDeReclamosPorAgente();
        }
    }
}