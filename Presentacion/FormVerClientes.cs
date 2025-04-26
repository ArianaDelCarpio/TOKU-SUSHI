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
    public partial class FormVerClientes : Form
    {
        NCliente nCliente = new NCliente();
        public FormVerClientes()
        {
            InitializeComponent();
            MostrarClientes(nCliente.ListarTodo());
        }

        private void MostrarClientes(List<Cliente> clientes)
        {
            dgClientes.DataSource = null;
            if (clientes.Count == 0)
            {
                return;
            }
            else
            {
                dgClientes.DataSource = clientes;
            }
        }

        private void btnVerPedidos_Click(object sender, EventArgs e)
        {
            if (dgClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente para ver sus pedidos");
                return;
            }
            int idCliente = int.Parse(dgClientes.SelectedRows[0].Cells[0].Value.ToString());
            FormVerPedidosPorCliente form = new FormVerPedidosPorCliente(idCliente);
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormPantallaPrincipalVistaAdministrador formPantallaPrincipalVistaAdministrador = new FormPantallaPrincipalVistaAdministrador();
            formPantallaPrincipalVistaAdministrador.Show();
            this.Hide();
        }

        private void FormVerClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
