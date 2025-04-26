using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Datos
{
    public class DProducto
    {
        public List<Productos> ListarTodo()
        {
            List<Productos> productos = new List<Productos>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    productos = context.Productos.ToList();

                }
                return productos;
            }
            catch (Exception)
            {
                return productos;
            }
        }
        public Decimal ObtenerPrecioProducto(int idProducto)
        {
            using (var context = new BDEFEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                Productos producto = context.Productos.SingleOrDefault(p => p.id_producto.Equals(idProducto));
                if (producto != null)
                {
                    return producto.precio_producto.Value;
                }
                else
                {
                    return 0;
                }
            }
        }

        public List<Productos> ListarProductosConReclamos()
        {
            List<Productos> productosConReseñas = new List<Productos>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    productosConReseñas = context.Productos
                        .Where(p => context.Producto_por_Pedido
                            .Any(PxP => PxP.id_producto.Equals(p.id_producto) &&
                                        context.Reclamo.Any(r => r.id_pedido.Equals(PxP.id_pedido) && r.id_producto.Equals(PxP.id_producto))))
                        .ToList();

                    return productosConReseñas;
                }
            }
            catch (Exception)
            {
                return productosConReseñas;
            }
        }
        public List<ProductosConReclamos> ListarProductosConMayorCantidadReclamos()
        {
            List<ProductosConReclamos> productosReclamos = new List<ProductosConReclamos>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    productosReclamos = context.ProductosConReclamos
                    .OrderByDescending(p => p.cantidad_reclamos)
                    .ToList();
                }
                return productosReclamos;
            }
            catch (Exception)
            {
                return productosReclamos;
            }
        }
        public List<ProductosMasVendidos> ListarProductosMasVendidos()
        {
            List<ProductosMasVendidos> productosMasVendidos = new List<ProductosMasVendidos>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    productosMasVendidos = context.ProductosMasVendidos
                    .OrderByDescending(p => p.total_vendido)
                    .ToList();
                }
                return productosMasVendidos;
            }
            catch (Exception)
            {
                return productosMasVendidos;
            }
        }
        public List<ProductosMejorCalificados> ListarProductosMejorCalificados()
        {
            List<ProductosMejorCalificados> productosMejorCalificados = new List<ProductosMejorCalificados>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    productosMejorCalificados = context.ProductosMejorCalificados
                    .OrderByDescending(p => p.calificacion_promedio)
                    .ToList();
                }
                return productosMejorCalificados;
            }
            catch (Exception)
            {
                return productosMejorCalificados;
            }
        }
    }
}
