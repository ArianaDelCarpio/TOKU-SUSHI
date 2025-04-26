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
    public partial class FormVerReseñasPorProducto : Form
    {
        NReclamo nReclamo = new NReclamo();
        int idProducto;
        public FormVerReseñasPorProducto(int ID_Producto)
        {
            InitializeComponent();
            idProducto = ID_Producto;
            MostrarReclamosPorProducto(nReclamo.ListarReclamosPorProducto(idProducto));
        }

        private void MostrarReclamosPorProducto(List<Reclamo> reclamos)
        {
            dgReclamos.DataSource = null;
            if (reclamos.Count == 0)
            {
                return;
            }
            else
            {
                dgReclamos.DataSource = reclamos;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormVerProductosConReseñas formVerProductosConReseñas = new FormVerProductosConReseñas();
            formVerProductosConReseñas.Show();
            this.Hide();
        }

        private void FormVerReseñasPorProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}