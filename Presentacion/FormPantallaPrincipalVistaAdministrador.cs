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
    public partial class FormPantallaPrincipalVistaAdministrador : Form
    {
        public FormPantallaPrincipalVistaAdministrador()
        {
            InitializeComponent();
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            FormVerClientes formVerClientes = new FormVerClientes();
            formVerClientes.Show();
            this.Hide();
        }

        private void btnVerReseña_Click(object sender, EventArgs e)
        {
            FormVerProductosConReseñas formVerProductosConReseñas = new FormVerProductosConReseñas();
            formVerProductosConReseñas.Show();
            this.Hide();
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            FormVerReportes form = new FormVerReportes();
            form.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FormIniciarSesion formInicioSesion = new FormIniciarSesion();
            formInicioSesion.Show();
            this.Hide();
        }

        private void FormPantallaPrincipalVistaAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}