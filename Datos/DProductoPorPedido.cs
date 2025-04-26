using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DProductoPorPedido
    {
        public String Asignar(Producto_por_Pedido productoPorPedido)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Producto_por_Pedido.Add(productoPorPedido);
                    context.SaveChanges();
                }
                return "Producto añadido al pedido";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String Desasignar(int idPedido, int idProducto)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Producto_por_Pedido ProductoPorPedidoTemp = context.Producto_por_Pedido.Find(idPedido, idProducto);
                    context.Producto_por_Pedido.Remove(ProductoPorPedidoTemp);
                    context.SaveChanges();
                }
                return "Se removió el producto del pedido";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public bool EsProductoRegistradoEnPedido(int idPedido, int idProducto)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    return context.Producto_por_Pedido.Any(pp => pp.id_pedido.Equals(idPedido) && pp.id_producto.Equals(idProducto));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar si el producto ya está registrado en el pedido", ex);
            }
        }
        public String ModificarCantidadPedido(Producto_por_Pedido productoPorPedido)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Producto_por_Pedido ProductoPorPedidoTemp = context.Producto_por_Pedido.Find(productoPorPedido.id_pedido, productoPorPedido.id_producto);
                    ProductoPorPedidoTemp.id_pedido = productoPorPedido.id_pedido;
                    ProductoPorPedidoTemp.id_producto = productoPorPedido.id_producto;
                    ProductoPorPedidoTemp.cantidad_producto = productoPorPedido.cantidad_producto;
                    ProductoPorPedidoTemp.subtotal_producto = productoPorPedido.subtotal_producto;
                    context.SaveChanges();
                }
                return "Se modificó la cantidad del pedido";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String DesasignarTodosLosProductos(int idPedido)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    List<Producto_por_Pedido> ProductoPorPedidoTemp = context.Producto_por_Pedido.Where(PxP => PxP.id_pedido.Equals(idPedido)).ToList();
                    context.Producto_por_Pedido.RemoveRange(ProductoPorPedidoTemp);
                    context.SaveChanges();
                }
                return "Se removieron todos los productos del pedido";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Producto_por_Pedido> ListarTodo()
        {
            List<Producto_por_Pedido> Productos_Por_Pedido = new List<Producto_por_Pedido>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    Productos_Por_Pedido = context.Producto_por_Pedido.ToList();

                }
                return Productos_Por_Pedido;
            }
            catch (Exception)
            {
                return Productos_Por_Pedido;
            }
        }

        public List<Producto_por_Pedido> ListarPorIDPedido(int idPedido)
        {
            List<Producto_por_Pedido> Productos_Por_Pedido = new List<Producto_por_Pedido>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    Productos_Por_Pedido = context.Producto_por_Pedido.Where(PxP => PxP.id_pedido.Equals(idPedido)).ToList();

                }
                return Productos_Por_Pedido;
            }
            catch (Exception)
            {
                return Productos_Por_Pedido;
            }
        }

        public List<Producto_por_Pedido> ListarPorCliente(int idCliente)
        {
            List<Producto_por_Pedido> Productos_Por_Pedido = new List<Producto_por_Pedido>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    Productos_Por_Pedido = context.Producto_por_Pedido.Where(PxP => PxP.Pedido.id_cliente.Equals(idCliente)).ToList();

                }
                return Productos_Por_Pedido;
            }
            catch (Exception)
            {
                return Productos_Por_Pedido;
            }
        }
    }
}
