
namespace Presentacion
{
    partial class FormVerReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerReportes));
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.btnMayorReclamos = new Guna.UI2.WinForms.Guna2Button();
            this.btnProductoMasVendido = new Guna.UI2.WinForms.Guna2Button();
            this.btnClienteMasPedidos = new Guna.UI2.WinForms.Guna2Button();
            this.btnPedidoMejorCalificacion = new Guna.UI2.WinForms.Guna2Button();
            this.btnSalir = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnListarCantidadDeReclamosPorAgente = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProductos
            // 
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Location = new System.Drawing.Point(278, 98);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.ReadOnly = true;
            this.dgProductos.Size = new System.Drawing.Size(448, 290);
            this.dgProductos.TabIndex = 53;
            // 
            // btnMayorReclamos
            // 
            this.btnMayorReclamos.BorderRadius = 12;
            this.btnMayorReclamos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMayorReclamos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMayorReclamos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMayorReclamos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMayorReclamos.FillColor = System.Drawing.Color.White;
            this.btnMayorReclamos.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMayorReclamos.ForeColor = System.Drawing.Color.Black;
            this.btnMayorReclamos.Location = new System.Drawing.Point(28, 98);
            this.btnMayorReclamos.Name = "btnMayorReclamos";
            this.btnMayorReclamos.Size = new System.Drawing.Size(218, 68);
            this.btnMayorReclamos.TabIndex = 52;
            this.btnMayorReclamos.Text = "Listar producto con mayor cantidad de reclamos";
            this.btnMayorReclamos.Click += new System.EventHandler(this.btnMayorReclamos_Click);
            // 
            // btnProductoMasVendido
            // 
            this.btnProductoMasVendido.BorderRadius = 12;
            this.btnProductoMasVendido.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProductoMasVendido.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProductoMasVendido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductoMasVendido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProductoMasVendido.FillColor = System.Drawing.Color.White;
            this.btnProductoMasVendido.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductoMasVendido.ForeColor = System.Drawing.Color.Black;
            this.btnProductoMasVendido.Location = new System.Drawing.Point(28, 172);
            this.btnProductoMasVendido.Name = "btnProductoMasVendido";
            this.btnProductoMasVendido.Size = new System.Drawing.Size(218, 57);
            this.btnProductoMasVendido.TabIndex = 51;
            this.btnProductoMasVendido.Text = "Mostrar Producto más vendido";
            this.btnProductoMasVendido.Click += new System.EventHandler(this.btnProductoMasVendido_Click);
            // 
            // btnClienteMasPedidos
            // 
            this.btnClienteMasPedidos.BorderRadius = 12;
            this.btnClienteMasPedidos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClienteMasPedidos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClienteMasPedidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClienteMasPedidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClienteMasPedidos.FillColor = System.Drawing.Color.White;
            this.btnClienteMasPedidos.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteMasPedidos.ForeColor = System.Drawing.Color.Black;
            this.btnClienteMasPedidos.Location = new System.Drawing.Point(28, 235);
            this.btnClienteMasPedidos.Name = "btnClienteMasPedidos";
            this.btnClienteMasPedidos.Size = new System.Drawing.Size(218, 45);
            this.btnClienteMasPedidos.TabIndex = 50;
            this.btnClienteMasPedidos.Text = "Mostrar cliente con mayor cantidad de pedidos";
            this.btnClienteMasPedidos.Click += new System.EventHandler(this.btnClienteMasPedidos_Click);
            // 
            // btnPedidoMejorCalificacion
            // 
            this.btnPedidoMejorCalificacion.BorderRadius = 12;
            this.btnPedidoMejorCalificacion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPedidoMejorCalificacion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPedidoMejorCalificacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPedidoMejorCalificacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPedidoMejorCalificacion.FillColor = System.Drawing.Color.White;
            this.btnPedidoMejorCalificacion.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoMejorCalificacion.ForeColor = System.Drawing.Color.Black;
            this.btnPedidoMejorCalificacion.Location = new System.Drawing.Point(28, 286);
            this.btnPedidoMejorCalificacion.Name = "btnPedidoMejorCalificacion";
            this.btnPedidoMejorCalificacion.Size = new System.Drawing.Size(218, 45);
            this.btnPedidoMejorCalificacion.TabIndex = 49;
            this.btnPedidoMejorCalificacion.Text = "Mostrar Productos con mejor calificacion";
            this.btnPedidoMejorCalificacion.Click += new System.EventHandler(this.btnPedidoMejorCalificacion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BorderRadius = 12;
            this.btnSalir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalir.FillColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(28, 397);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(180, 45);
            this.btnSalir.TabIndex = 48;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(689, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 85);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // btnListarCantidadDeReclamosPorAgente
            // 
            this.btnListarCantidadDeReclamosPorAgente.BorderRadius = 12;
            this.btnListarCantidadDeReclamosPorAgente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListarCantidadDeReclamosPorAgente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListarCantidadDeReclamosPorAgente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListarCantidadDeReclamosPorAgente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnListarCantidadDeReclamosPorAgente.FillColor = System.Drawing.Color.White;
            this.btnListarCantidadDeReclamosPorAgente.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarCantidadDeReclamosPorAgente.ForeColor = System.Drawing.Color.Black;
            this.btnListarCantidadDeReclamosPorAgente.Location = new System.Drawing.Point(28, 337);
            this.btnListarCantidadDeReclamosPorAgente.Name = "btnListarCantidadDeReclamosPorAgente";
            this.btnListarCantidadDeReclamosPorAgente.Size = new System.Drawing.Size(218, 45);
            this.btnListarCantidadDeReclamosPorAgente.TabIndex = 54;
            this.btnListarCantidadDeReclamosPorAgente.Text = "Listar cantidad de reclamos por Agente";
            this.btnListarCantidadDeReclamosPorAgente.Click += new System.EventHandler(this.btnListarCantidadDeReclamosPorAgente_Click);
            // 
            // FormVerReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(785, 518);
            this.Controls.Add(this.btnListarCantidadDeReclamosPorAgente);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.btnMayorReclamos);
            this.Controls.Add(this.btnProductoMasVendido);
            this.Controls.Add(this.btnClienteMasPedidos);
            this.Controls.Add(this.btnPedidoMejorCalificacion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormVerReportes";
            this.Text = "Reportes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVerReportes_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProductos;
        private Guna.UI2.WinForms.Guna2Button btnMayorReclamos;
        private Guna.UI2.WinForms.Guna2Button btnProductoMasVendido;
        private Guna.UI2.WinForms.Guna2Button btnClienteMasPedidos;
        private Guna.UI2.WinForms.Guna2Button btnPedidoMejorCalificacion;
        private Guna.UI2.WinForms.Guna2Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnListarCantidadDeReclamosPorAgente;
    }
}