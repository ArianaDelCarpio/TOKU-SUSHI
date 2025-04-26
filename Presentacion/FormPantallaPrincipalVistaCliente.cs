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
    public partial class FormPantallaPrincipalVistaCliente : Form
    {
        private int idCliente;
        private NPedido nPedido = new NPedido();
        private NCliente nCliente = new NCliente();
        public FormPantallaPrincipalVistaCliente(int ID_Cliente)
        {
            InitializeComponent();
            idCliente = ID_Cliente;
            MostrarNombreCliente();
        }

        private void MostrarNombreCliente()
        {
            lblNombreCliente.Text = nCliente.DevolverNombreDelCliente(idCliente);
        }

        private void btnRegistrarPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido()
            {
                fecha = DateTime.Now,
                total = 0,
                id_cliente = idCliente
            };

            int idPedido = nPedido.Registrar(pedido);

            FormRegistrarPedidoCliente formRegistrar = new FormRegistrarPedidoCliente(idPedido, idCliente);
            formRegistrar.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIniciarSesion form = new FormIniciarSesion();
            form.Show();
        }

        private void btnRegistrarReseña_Click(object sender, EventArgs e)
        {
            FormPantallaRegistroReseñaCliente formRegistroReseñaCliente = new FormPantallaRegistroReseñaCliente(idCliente);
            formRegistroReseñaCliente.Show();
            this.Hide();
        }

        private void FormPantallaPrincipalVistaCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
