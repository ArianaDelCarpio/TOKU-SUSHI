using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DPedido
    {
        public int Registrar(Pedido pedido)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Pedido.Add(pedido);
                    context.SaveChanges();
                }
                return pedido.id_pedido;
            }
            catch (Exception)
            {

                return 0;
            }
            
        }

        public String Eliminar(int idpedido)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Pedido pedidoTemp = context.Pedido.Find(idpedido);
                    context.Pedido.Remove(pedidoTemp);
                    context.SaveChanges();
                }
                return "Se canceló el pedido";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String ModificarTotalPrecioPedidoExistente(int ID_Pedido, Decimal NuevoPrecio)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Pedido pedidoTemp = context.Pedido.Find(ID_Pedido);
                    pedidoTemp.total = NuevoPrecio;
                    context.SaveChanges();
                }
                return "Se modificó correctamente el precio total";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Pedido> ListarTodo()
        {
            List<Pedido> pedidos = new List<Pedido>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    pedidos = context.Pedido.ToList();

                }
                return pedidos;
            }
            catch (Exception)
            {
                return pedidos;
            }
        }

        public List<Pedido> ListarPedidosPorIDCliente(int idClienteSeleccionado)
        {
            List<Pedido> pedidos = new List<Pedido>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    pedidos = context.Pedido.Where(p=>p.id_cliente.Equals(idClienteSeleccionado)).ToList();

                }
                return pedidos;
            }
            catch (Exception)
            {
                return pedidos;
            }
        }
    }
}