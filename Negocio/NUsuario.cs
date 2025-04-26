using Datos;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class NUsuario
    {
        private DUsuario dUsuario = new DUsuario();
        public String Registrar(Usuario usuario)
        {
            return dUsuario.Registrar(usuario);
        }
        public List<Usuario> ListarTodo()
        {
            return dUsuario.ListarTodo();
        }
        public bool VerificarCredencialesUsuario(String NombreUsuario, String Contraseña)
        {
            return dUsuario.VerificarCredencialesUsuario(NombreUsuario, Contraseña);
        }
        public bool VerificarSiEsAdministrador(String NombreUsuario)
        {
            return dUsuario.VerificarSiEsAdministrador(NombreUsuario);
        }
        public int ObtenerIDCliente(String NombreUsuario)
        {
            return dUsuario.ObtenerIDCliente(NombreUsuario);
        }
        public bool VerificarUsuarioRegistrado(String usuarioVerificar)
        {
            return dUsuario.VerificarUsuarioRegistrado(usuarioVerificar);
        }
    }
}