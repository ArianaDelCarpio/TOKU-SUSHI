using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormRegistrarPedidoCliente : Form
    {
        private NProducto nProducto = new NProducto();
        private NPedido nPedido = new NPedido();
        private NProductoPorPedido nProductoPorPedido = new NProductoPorPedido();
        private int idPedido;
        private int idCliente;
        Decimal MontoTotal;
        public FormRegistrarPedidoCliente(int ID_Pedido, int ID_Cliente)
        {
            InitializeComponent();
            idPedido = ID_Pedido;
            idCliente = ID_Cliente;
            MostrarProductos(nProducto.ListarTodo());
            MostrarProductosPorPedido(nProductoPorPedido.ListarPorIDPedido(idPedido));
        }

        private void MostrarProductos(List<Productos> productos)
        {
            cbCodigoProducto.DataSource = null;
            if (productos.Count == 0)
            {
                return;
            }
            cbCodigoProducto.DataSource = productos;
            cbCodigoProducto.ValueMember = "id_producto";
            cbCodigoProducto.DisplayMember = "nombre_producto";
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
            lblMontoTotal.Text = MontoTotal.ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbCodigoProducto.Text == "" || tbCantidad.Text == "")
            {
                MessageBox.Show("Ingrese los campos necesarios para el registro de pedido",
                    "Advertencia: Ingreso de campos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int idProducto = int.Parse(cbCodigoProducto.SelectedValue.ToString());
            int cantidadProducto;

            if (nProductoPorPedido.EsProductoRegistradoEnPedido(idPedido, idProducto))
            {
                MessageBox.Show("El producto ya fue registrado, si desea añadir más debe de modificar la cantidad",
                    "Advertencia: Producto ya ingresado en el pedido",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                cantidadProducto = int.Parse(tbCantidad.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un numero válido para la cantidad de producto",
                    "Advertencia: Número inválido para la cantidad de producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Decimal PrecioProducto = nProducto.ObtenerPrecioProducto(idProducto);
            Decimal SubTotal = cantidadProducto * PrecioProducto;
            MontoTotal += SubTotal;

            Producto_por_Pedido productoPorPedido = new Producto_por_Pedido()
            {
                id_pedido = idPedido,
                id_producto = idProducto,
                cantidad_producto = cantidadProducto,
                subtotal_producto = SubTotal
            };

            String mensaje_exitoso = nProductoPorPedido.Asignar(productoPorPedido);
            MessageBox.Show(mensaje_exitoso,
                    "Producto agregado al pedido",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            MostrarProductosPorPedido(nProductoPorPedido.ListarPorIDPedido(idPedido));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgProductosXPedido.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto a eliminar");
                return;
            }

            int idProducto = int.Parse(dgProductosXPedido.SelectedRows[0].Cells[1].Value.ToString());
            Decimal Subtotal = Decimal.Parse(dgProductosXPedido.SelectedRows[0].Cells[3].Value.ToString());
            MontoTotal -= Subtotal;

            String mensaje_eliminar = nProductoPorPedido.Desasignar(idPedido, idProducto);
            MessageBox.Show(mensaje_eliminar,
                    "Producto eliminado del pedido",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            MostrarProductosPorPedido(nProductoPorPedido.ListarPorIDPedido(idPedido));
        }

        private void btnModificarCantidad_Click(object sender, EventArgs e)
        {
            if (dgProductosXPedido.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para modificar la cantidad",
                    "Advertencia: Selección de producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (tbCantidad.Text == "")
            {
                MessageBox.Show("Ingrese cantidad para modificar",
                    "Advertencia: No se ingresó cantidad",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int cantidadProducto;
            try
            {
                cantidadProducto = int.Parse(tbCantidad.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un numero válido para la cantidad de producto",
                    "Advertencia: No se ingresó un número",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cantidadProducto < 0)
            {
                MessageBox.Show("La cantidad ingresada de producto debe ser mayor que 0",
                    "Advertencia: Cantidad ingresada inválida",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cantidadProducto > 20)
            {
                MessageBox.Show("La cantidad ingresada no puede exceder las 20 unidades",
                    "Advertencia: Cantidad ingresada excede a 20",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int idProducto = int.Parse(dgProductosXPedido.SelectedRows[0].Cells[1].Value.ToString());
            Decimal SubtotalAnterior = Decimal.Parse(dgProductosXPedido.SelectedRows[0].Cells[3].Value.ToString());
            MontoTotal -= SubtotalAnterior;

            Decimal PrecioProducto = nProducto.ObtenerPrecioProducto(idProducto);
            Decimal SubTotal = cantidadProducto * PrecioProducto;
            MontoTotal += SubTotal;

            Producto_por_Pedido productoPorPedido = new Producto_por_Pedido()
            {
                id_pedido = idPedido,
                id_producto = idProducto,
                cantidad_producto = cantidadProducto,
                subtotal_producto = SubTotal
            };

            String mensaje_modificar = nProductoPorPedido.ModificarCantidadPedido(productoPorPedido);
            MessageBox.Show(mensaje_modificar,
                    "Producto modificado del pedido",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            MostrarProductosPorPedido(nProductoPorPedido.ListarPorIDPedido(idPedido));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult mensajeConfirmacion = MessageBox.Show("¿Estas seguro que quieres cancelar el pedido?", "", MessageBoxButtons.YesNo);
            if (mensajeConfirmacion.Equals(DialogResult.Yes))
            {
                String mensaje_eliminar_pedidos = nProductoPorPedido.DesasignarTodosLosProductos(idPedido);
                String mensaje = nPedido.Eliminar(idPedido);
                MessageBox.Show(mensaje,
                    "Se canceló el pedido",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                FormPantallaPrincipalVistaCliente formPantallaPrincipalVistaCliente = new FormPantallaPrincipalVistaCliente(idCliente);
                formPantallaPrincipalVistaCliente.Show();
                this.Hide();
            }
        }

        private void btnConfirmarPedido_Click(object sender, EventArgs e)
        {
            DialogResult mensajeConfirmacion = MessageBox.Show("Se confirmará el pedido, ¿Quieres confirmarlo?", "", MessageBoxButtons.YesNo);
            if (mensajeConfirmacion.Equals(DialogResult.Yes))
            {
                String mensaje_pedido_realizado = nPedido.ModificarTotalPrecioPedidoExistente(idPedido, MontoTotal);
                FormPantallaPrincipalVistaCliente formPantallaPrincipalVistaCliente = new FormPantallaPrincipalVistaCliente(idCliente);
                formPantallaPrincipalVistaCliente.Show();
                this.Hide();
            }
        }

        private void FormRegistrarPedidoCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            String mensaje_eliminar_pedidos = nProductoPorPedido.DesasignarTodosLosProductos(idPedido);
            String mensaje = nPedido.Eliminar(idPedido);
            Application.Exit();
        }

        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }        
        }
    }
}