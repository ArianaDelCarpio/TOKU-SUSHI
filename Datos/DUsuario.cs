using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DUsuario
    {
        public String Registrar(Usuario usuario)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Usuario.Add(usuario);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            
        }
        public bool VerificarCredencialesUsuario(String NombreUsuario, String Contraseña)
        {
            using (var context = new BDEFEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                Usuario usuario = context.Usuario.SingleOrDefault(u => u.nombre_usuario.Equals(NombreUsuario));
                if (usuario != null && usuario.contrasenia == Contraseña)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool VerificarSiEsAdministrador(String NombreUsuario)
        {
            using (var context = new BDEFEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                Usuario usuario = context.Usuario.SingleOrDefault(u => u.nombre_usuario.Equals(NombreUsuario));
                if (usuario != null && usuario.rol == "Administrador")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public int ObtenerIDCliente(String NombreUsuario)
        {
            using (var context = new BDEFEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                Usuario usuario = context.Usuario.SingleOrDefault(u => u.nombre_usuario.Equals(NombreUsuario));
                if (usuario != null)
                {
                    return usuario.cliente_id.Value;
                }
                else
                {
                    return 0;
                }
            }
        }
        public List<Usuario> ListarTodo()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    usuarios = context.Usuario.ToList();

                }
                return usuarios;
            }
            catch (Exception)
            {
                return usuarios;
            }
        }
        public bool VerificarUsuarioRegistrado(String usuarioVerificar)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    return context.Usuario.Any(u => u.nombre_usuario.Equals(usuarioVerificar));
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
