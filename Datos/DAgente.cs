using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class DAgente
    {
        public List<Agente> ListarTodo()
        {
            List<Agente> agente = new List<Agente>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    agente = context.Agente.ToList();
                }
                return agente;
            }
            catch (Exception)
            {
                return agente;
            }
        }
        public List<CantidadDeReclamosPorAgente> ListarCantidadDeReclamosPorAgente()
        {
            List<CantidadDeReclamosPorAgente> reclamosPorAgente = new List<CantidadDeReclamosPorAgente>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    reclamosPorAgente = context.CantidadDeReclamosPorAgente
                        .OrderByDescending(a => a.cantidad_reclamos)
                        .ToList();
                }
                return reclamosPorAgente;
            }
            catch (Exception)
            {
                return reclamosPorAgente;
            }
        }
    }
}
