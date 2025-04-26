using Datos;
using Negocio;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormPantallaRegistroDeCliente : Form
    {
        private NCliente nCliente = new NCliente();
        private NUsuario nUsuario = new NUsuario();
        int ID_Cliente;
        public FormPantallaRegistroDeCliente()
        {
            InitializeComponent();
        }
        private bool ValidarSiEsCorreoElectronico(string correoElectronico)
        {
            String sFormatoEmail;
            sFormatoEmail = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correoElectronico, sFormatoEmail))
            {
                if (Regex.Replace(correoElectronico, sFormatoEmail, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (tbNombres.Text == "" || tbApellidos.Text == "" || tbDNI.Text == "" ||
                tbCorreoElectronico.Text == "" || tbNumero.Text == "" || tbNombreUsuario.Text == "" ||
                tbContraseña.Text == "")
            {
                MessageBox.Show("Debe de ingresar todos los campos",
                    "Advertencia: Ingreso de todos los campos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            String DNICliente = tbDNI.Text;

            if (nCliente.VerificarDNIRegistrado(DNICliente))
            {
                MessageBox.Show("El DNI ya fue registrado anteriormente",
                    "Advertencia: DNI ya registrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            String correoCliente = tbCorreoElectronico.Text;

            if (!(ValidarSiEsCorreoElectronico(correoCliente)))
            {
                MessageBox.Show("El correo ingresado no cuenta con el formato requerido",
                    "Advertencia: Correo electrónico no válido",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (nCliente.VerificarCorreoRegistrado(correoCliente))
            {
                MessageBox.Show("El usuario ya se encuentra registrado con el correo brindado.",
                    "Advertencia: Usuario ya registrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            String telefonoCliente = tbNumero.Text;

            if (nCliente.VerificarNumeroDeTelefonoRegistrado(telefonoCliente))
            {
                MessageBox.Show("El número de teléfono ya fue registrado anteriormente",
                    "Advertencia: Número de teléfono ya registrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            String NombreDeUsuario = tbNombreUsuario.Text;

            if (nUsuario.VerificarUsuarioRegistrado(NombreDeUsuario))
            {
                MessageBox.Show("El nombre de usuario ya existe, escoja otro nombre de usuario",
                    "Advertencia: Nombre de usuario ya registrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            String Tipo_Usuario = "Cliente";

            Cliente cliente = new Cliente()
            {
                nombres = tbNombres.Text,
                apellidos = tbApellidos.Text,
                email = correoCliente,
                telefono = tbNumero.Text,
                dni = DNICliente
            };

            ID_Cliente = nCliente.Registrar(cliente);

            if (ID_Cliente == 0)
            {
                MessageBox.Show("Ocurrió un error inesperado al hacer conexión con la base de datos",
                    "Error: Conexión a la base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario usuario = new Usuario()
            {
                contrasenia = tbContraseña.Text,
                rol = Tipo_Usuario,
                nombre_usuario = NombreDeUsuario,
                cliente_id = ID_Cliente
            };

            String registro_usuario = nUsuario.Registrar(usuario);

            MessageBox.Show(registro_usuario, "¡Bienvenido a TokuSushi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormPantallaPrincipalVistaCliente formPantallaPrincipalVistaCliente = new FormPantallaPrincipalVistaCliente(ID_Cliente);
            formPantallaPrincipalVistaCliente.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormIniciarSesion formInicioSesion = new FormIniciarSesion();
            formInicioSesion.Show();
            this.Hide();
        }

        private void tbDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (tbDNI.Text.Length >= 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("El máximo de caractéres permitidos para el DNI son 8",
                    "Notificación: Longitud de DNI",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void tbNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ' '))
            {
                MessageBox.Show("Para el ingreso de Nombre debe de escribir solo letras.",
                    "Notificación: Ingreso de nombre solo letras",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void tbApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ' '))
            {
                MessageBox.Show("Para el ingreso de Apellidos debe de escribir solo letras.",
                    "Notificación: Ingreso de nombre solo letras",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (tbNumero.Text.Length >= 9 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("El máximo de caractéres permitidos para el número de teléfono son 9",
                    "Notificación: Longitud de número de teléfono",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void FormPantallaRegistroDeCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}