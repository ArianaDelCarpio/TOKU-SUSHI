using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;

namespace Negocio
{
    public class NProducto
    {
        private DProducto dProducto = new DProducto();
        public List<Productos> ListarTodo()
        {
            return dProducto.ListarTodo();
        }
        public Decimal ObtenerPrecioProducto(int idProducto)
        {
            return dProducto.ObtenerPrecioProducto(idProducto);
        }
        public List<Productos> ListarProductosConReclamos()
        {
            return dProducto.ListarProductosConReclamos();
        }
        public List<ProductosConReclamos> ListarProductosConMayorCantidadReclamos()
        {
            return dProducto.ListarProductosConMayorCantidadReclamos();
        }
        public List<ProductosMasVendidos> ListarProductosMasVendidos()
        {
            return dProducto.ListarProductosMasVendidos();
        }
        public List<ProductosMejorCalificados> ListarProductosMejorCalificados()
        {
            return dProducto.ListarProductosMejorCalificados();
        }
    }
}