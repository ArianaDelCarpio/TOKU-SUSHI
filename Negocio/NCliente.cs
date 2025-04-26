using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NCliente
    {
        private DCliente dCliente = new DCliente();
        public int Registrar(Cliente cliente)
        {
            return dCliente.Registrar(cliente);
        }
        public List<Cliente> ListarTodo()
        {
            return dCliente.ListarTodo();
        }
        public bool VerificarCorreoRegistrado(String correoVerificar)
        {
            return dCliente.VerificarCorreoRegistrado(correoVerificar);
        }
        public bool VerificarDNIRegistrado(String DNI)
        {
            return dCliente.VerificarDNIRegistrado(DNI);
        }
        public bool VerificarNumeroDeTelefonoRegistrado(String numTelefono)
        {
            return dCliente.VerificarNumeroDeTelefonoRegistrado(numTelefono);
        }
        public List<CantidadDePedidosPorCliente> ListarClientesConMasPedidos()
        {
            return dCliente.ListarClientesConMasPedidos();
        }
        public String DevolverNombreDelCliente(int idCliente)
        {
            return dCliente.DevolverNombreDelCliente(idCliente);
        }
    }
}