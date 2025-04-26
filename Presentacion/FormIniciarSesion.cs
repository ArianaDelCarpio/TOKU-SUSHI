using Negocio;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormIniciarSesion : Form
    {
        private NUsuario nUsuario = new NUsuario();
        private NCliente nCliente = new NCliente();
        public FormIniciarSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (TbUsuario.Text == "" || tbContraseña.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos requeridos");
                return;
            }

            String Nombre_de_Usuario = TbUsuario.Text;
            String Contraseña = tbContraseña.Text;

            if (!(nUsuario.VerificarCredencialesUsuario(Nombre_de_Usuario, Contraseña)))
            {
                MessageBox.Show("Credenciales incorrectas, vuelva a intentarlo");
                return;
            }

            int idCliente = nUsuario.ObtenerIDCliente(Nombre_de_Usuario);

            if (nUsuario.VerificarSiEsAdministrador(Nombre_de_Usuario))
            {
                FormPantallaPrincipalVistaAdministrador formPantallaPrincipalVistaAdministrador = new FormPantallaPrincipalVistaAdministrador();
                formPantallaPrincipalVistaAdministrador.Show();
                this.Hide();
            }
            else
            {
                FormPantallaPrincipalVistaCliente form = new FormPantallaPrincipalVistaCliente(idCliente);
                form.Show();
                this.Hide();
            }
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            FormPantallaRegistroDeCliente formPantallaRegistroDeCliente = new FormPantallaRegistroDeCliente();
            formPantallaRegistroDeCliente.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormInicio formInicio = new FormInicio();
            formInicio.Show();
            this.Hide();
        }

        private void FormIniciarSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
