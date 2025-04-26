using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DReclamo
    {
        public String Registrar(Reclamo reclamo)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Reclamo.Add(reclamo);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Reclamo> ListarTodo()
        {
            List<Reclamo> reclamos = new List<Reclamo>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    reclamos = context.Reclamo.ToList();

                }
                return reclamos;
            }
            catch (Exception)
            {
                return reclamos;
            }
        }
        public List<Reclamo> ListarReclamosPorProducto(int idProducto)
        {
            List<Reclamo> reclamosPorProducto = new List<Reclamo>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    reclamosPorProducto = context.Reclamo
                        .Where(r => r.id_producto == idProducto)
                        .ToList();
                }
                return reclamosPorProducto;
            }
            catch (Exception)
            {
                return reclamosPorProducto;
            }
        }
    }
}
