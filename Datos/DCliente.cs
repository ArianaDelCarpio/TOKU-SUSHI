using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCliente
    {
        public int Registrar(Cliente cliente)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Cliente.Add(cliente);
                    context.SaveChanges();
                    return cliente.id_cliente;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public List<Cliente> ListarTodo()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    clientes = context.Cliente.ToList();

                }
                return clientes;
            }
            catch (Exception)
            {
                return clientes;
            }
        }
        public bool VerificarCorreoRegistrado(String correoVerificar)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    return context.Cliente.Any(c => c.email.Equals(correoVerificar));
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool VerificarDNIRegistrado(String DNI)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    return context.Cliente.Any(c => c.dni.Equals(DNI));
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool VerificarNumeroDeTelefonoRegistrado(String numTelefono)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    return context.Cliente.Any(c => c.telefono.Equals(numTelefono));
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<CantidadDePedidosPorCliente> ListarClientesConMasPedidos()
        {
            List<CantidadDePedidosPorCliente> clientesConMasPedidos = new List<CantidadDePedidosPorCliente>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    clientesConMasPedidos = context.CantidadDePedidosPorCliente
                    .OrderByDescending(c => c.cantidad_pedidos)
                    .ToList();
                }
                return clientesConMasPedidos;
            }
            catch (Exception)
            {
                return clientesConMasPedidos;
            }
        }

        public String DevolverNombreDelCliente(int idCliente)
        {
            Cliente cliente = new Cliente();
            String nombreCliente = "";
            try
            {
                using (var context = new BDEFEntities())
                {
                    cliente = context.Cliente.FirstOrDefault(c => c.id_cliente == idCliente);
                    if (cliente != null)
                    {
                        nombreCliente = $"{cliente.nombres} {cliente.apellidos}";
                    }
                }
                return nombreCliente;
            }
            catch (Exception)
            {
                return nombreCliente;
            }
        }
    }
}
