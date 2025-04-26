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
    public partial class FormVerPedidosPorCliente : Form
    {
        NPedido nPedido = new NPedido();
        public FormVerPedidosPorCliente(int ID_Cliente)
        {
            InitializeComponent();
            MostrarPedidos(nPedido.ListarPedidosPorIDCliente(ID_Cliente));
        }

        private void MostrarPedidos(List<Pedido> pedidos)
        {
            dgPedidos.DataSource = null;
            if (pedidos.Count == 0)
            {
                return;
            }
            else
            {
                dgPedidos.DataSource = pedidos;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormVerClientes formVerClientes = new FormVerClientes();
            this.Show();
            this.Hide();
        }

        private void FormVerPedidosPorCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
