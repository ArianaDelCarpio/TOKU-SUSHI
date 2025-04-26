using Datos;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class NPedido
    {
        private DPedido dPedido = new DPedido();
        public int Registrar(Pedido pedido)
        {
            return dPedido.Registrar(pedido);
        }
        public String Eliminar(int idpedido)
        {
            return dPedido.Eliminar(idpedido);
        }
        public String ModificarTotalPrecioPedidoExistente(int ID_Pedido, Decimal NuevoPrecio)
        {
            return dPedido.ModificarTotalPrecioPedidoExistente(ID_Pedido, NuevoPrecio);
        }
        public List<Pedido> ListarTodo()
        {
            return dPedido.ListarTodo();
        }
        public List<Pedido> ListarPedidosPorIDCliente(int idClienteSeleccionado)
        {
            return dPedido.ListarPedidosPorIDCliente(idClienteSeleccionado);
        }
    }
}