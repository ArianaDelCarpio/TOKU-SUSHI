using Datos;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class NProductoPorPedido
    {
        DProductoPorPedido dProductoPorPedido = new DProductoPorPedido();
        public String Asignar(Producto_por_Pedido productoPorPedido)
        {
            return dProductoPorPedido.Asignar(productoPorPedido);
        }
        public String Desasignar(int idPedido, int idProducto)
        {
            return dProductoPorPedido.Desasignar(idPedido, idProducto);
        }
        public bool EsProductoRegistradoEnPedido(int idPedido, int idProducto)
        {
            return dProductoPorPedido.EsProductoRegistradoEnPedido(idPedido, idProducto);
        }
        public String ModificarCantidadPedido(Producto_por_Pedido productoPorPedido)
        {
            return dProductoPorPedido.ModificarCantidadPedido(productoPorPedido);
        }
        public String DesasignarTodosLosProductos(int idPedido)
        {
            return dProductoPorPedido.DesasignarTodosLosProductos(idPedido);
        }
        public List<Producto_por_Pedido> ListarTodo()
        {
            return dProductoPorPedido.ListarTodo();
        }
        public List<Producto_por_Pedido> ListarPorIDPedido(int idPedido)
        {
            return dProductoPorPedido.ListarPorIDPedido(idPedido);
        }
        public List<Producto_por_Pedido> ListarPorCliente(int idCliente)
        {
            return dProductoPorPedido.ListarPorCliente(idCliente);
        }
    }
}