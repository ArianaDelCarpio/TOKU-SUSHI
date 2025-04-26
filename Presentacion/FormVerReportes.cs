using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;

namespace Presentacion
{
    public partial class FormVerReportes : Form
    {
        private NProducto nProducto = new NProducto();
        private NCliente nCliente = new NCliente();
        private NAgente nAgente = new NAgente();
        public FormVerReportes()
        {
            InitializeComponent();
        }
        private void MostrarProductos(List<ProductosMasVendidos> productos)
        {
            dgProductos.DataSource = null;
            if (productos.Count == 0)
            {
                return;
            }
            else
            {
                dgProductos.DataSource = productos;
            }
        }

        private void MostrarProductosMejorCalificados(List<ProductosMejorCalificados> productosCalificados)
        {
            dgProductos.DataSource = null;
            if (productosCalificados.Count == 0)
            {
                return;
            }
            else
            {
                dgProductos.DataSource = productosCalificados;
            }
        }

        private void MostrarProductosConMayorCantidadReclamos(List<ProductosConReclamos> productosReclamos)
        {
            dgProductos.DataSource = null;
            if (productosReclamos.Count == 0)
            {
                return;
            }
            else
            {
                dgProductos.DataSource = productosReclamos;
            }
        }

        private void MostrarClientesConMasPedidos(List<CantidadDePedidosPorCliente> clientes)
        {
            dgProductos.DataSource = null;
            if (clientes.Count == 0)
            {
                return;
            }
            else
            {
                dgProductos.DataSource = clientes;
            }
        }

        private void MostrarAgentes(List<CantidadDeReclamosPorAgente> agentesReclamo)
        {
            dgProductos.DataSource = null;
            if (agentesReclamo.Count == 0)
            {
                return;
            }
            else
            {
                dgProductos.DataSource = agentesReclamo;
            }
        }

    private void btnSalir_Click(object sender, EventArgs e)
        {
            FormPantallaPrincipalVistaAdministrador formPantallaPrincipalVistaAdministrador = new FormPantallaPrincipalVistaAdministrador();
            formPantallaPrincipalVistaAdministrador.Show();
            this.Hide();
        }

        private void FormVerReportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnMayorReclamos_Click(object sender, EventArgs e)
        {
            MostrarProductosConMayorCantidadReclamos(nProducto.ListarProductosConMayorCantidadReclamos());
        }

        private void btnProductoMasVendido_Click(object sender, EventArgs e)
        {
            MostrarProductos(nProducto.ListarProductosMasVendidos());
        }

        private void btnClienteMasPedidos_Click(object sender, EventArgs e)
        {
            MostrarClientesConMasPedidos(nCliente.ListarClientesConMasPedidos());
        }

        private void btnPedidoMejorCalificacion_Click(object sender, EventArgs e)
        {
            MostrarProductosMejorCalificados(nProducto.ListarProductosMejorCalificados());
        }

        private void btnListarCantidadDeReclamosPorAgente_Click(object sender, EventArgs e)
        {
            MostrarAgentes(nAgente.ListarCantidadDeReclamosPorAgente());
        }
    }
}
