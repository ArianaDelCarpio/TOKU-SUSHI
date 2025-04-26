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
    public partial class FormPantallaRegistroReseñaCliente : Form
    {
        NReclamo nReclamo = new NReclamo();
        NProductoPorPedido nProductoPorPedido = new NProductoPorPedido();
        int idCliente;
        public FormPantallaRegistroReseñaCliente(int ID_Cliente)
        {
            InitializeComponent();
            idCliente = ID_Cliente;
            MostrarProductosPorPedido(nProductoPorPedido.ListarPorCliente(idCliente));
        }

        private void MostrarProductosPorPedido(List<Producto_por_Pedido> productosPorPedido)
        {
            dgProductosXPedido.DataSource = null;
            if (productosPorPedido.Count == 0)
            {
                return;
            }
            else
            {
                dgProductosXPedido.DataSource = productosPorPedido;
            }
        }

        private void btnRealizarReseña_Click(object sender, EventArgs e)
        {
            if (cbCategoria.Text == "" || tbPuntuacion.Text == "" || tbDescripcion.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos para ingresar la reseña."
                   , "Advertencia: Ingreso de campos",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgProductosXPedido.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un pedido para realizar la reseña"
                   , "Advertencia: Selección de pedido",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int idPedido = int.Parse(dgProductosXPedido.SelectedRows[0].Cells[0].Value.ToString());
            int idProducto = int.Parse(dgProductosXPedido.SelectedRows[0].Cells[1].Value.ToString());

            Decimal Calificacion;
            try
            {
                Calificacion = Decimal.Parse(tbPuntuacion.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un valor adecuado para la calificación"
                   , "Advertencia: Valor no admitido en calificación",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Calificacion > 5 || Calificacion < 0)
            {
                MessageBox.Show("La calificación puede ir entre 0 a 5"
                   , "Advertencia: Rango de calificación",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Random random = new Random();
            int id_agente = random.Next(1, 5);

            Reclamo reclamo = new Reclamo()
            {
                categoria = cbCategoria.Text,
                descripcion = tbDescripcion.Text,
                calificacion = Calificacion,
                fecha_reclamo = DateTime.Now.Date,
                id_pedido = idPedido,
                id_producto = idProducto,
                agente_id = id_agente
            };

            String mensaje_registro_resenia_exitoso = nReclamo.Registrar(reclamo);
            MessageBox.Show(mensaje_registro_resenia_exitoso,
                    "Se envió la reseña hacia el producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPantallaPrincipalVistaCliente formPantallaPrincipalVistaCliente = new FormPantallaPrincipalVistaCliente(idCliente);
            formPantallaPrincipalVistaCliente.Show();
        }

        private void FormPantallaRegistroReseñaCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tbPuntuacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '.'))
            {
                MessageBox.Show("Para registrar la calificación debe de introducir solo números en decimal"
                    , "Advertencia: Ingreso de número ",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
