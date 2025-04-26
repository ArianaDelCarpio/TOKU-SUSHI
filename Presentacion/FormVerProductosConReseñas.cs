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
    public partial class FormVerProductosConReseñas : Form
    {
        NProducto nProducto = new NProducto();
        public FormVerProductosConReseñas()
        {
            InitializeComponent();
            MostrarProductos(nProducto.ListarProductosConReclamos());
        }

        private void MostrarProductos(List<Productos> productos)
        {
            dgProductosConResenias.DataSource = null;
            if (productos.Count == 0)
            {
                return;
            }
            else
            {
                dgProductosConResenias.DataSource = productos;
            }
        }

        private void btnVerReseñas_Click(object sender, EventArgs e)
        {
            if (dgProductosConResenias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para ver sus reseñas.");
                return;
            }

            int idProducto = int.Parse(dgProductosConResenias.SelectedRows[0].Cells[0].Value.ToString());
            FormVerReseñasPorProducto formVer = new FormVerReseñasPorProducto(idProducto);
            formVer.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormPantallaPrincipalVistaAdministrador formPantallaPrincipalVistaAdministrador = new FormPantallaPrincipalVistaAdministrador();
            formPantallaPrincipalVistaAdministrador.Show();
            this.Hide();
        }

        private void FormVerProductosConReseñas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
