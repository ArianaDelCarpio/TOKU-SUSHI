
namespace Presentacion
{
    partial class FormPantallaRegistroReseñaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPantallaRegistroReseñaCliente));
            this.btnSalir = new Guna.UI2.WinForms.Guna2Button();
            this.btnRealizarReseña = new Guna.UI2.WinForms.Guna2Button();
            this.tbPuntuacion = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.dgProductosXPedido = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductosXPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnSalir.Location = new System.Drawing.Point(486, 373);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(180, 45);
            this.btnSalir.TabIndex = 42;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRealizarReseña
            // 
            this.btnRealizarReseña.BorderRadius = 12;
            this.btnRealizarReseña.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRealizarReseña.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRealizarReseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRealizarReseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRealizarReseña.FillColor = System.Drawing.Color.White;
            this.btnRealizarReseña.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarReseña.ForeColor = System.Drawing.Color.Black;
            this.btnRealizarReseña.Location = new System.Drawing.Point(486, 322);
            this.btnRealizarReseña.Name = "btnRealizarReseña";
            this.btnRealizarReseña.Size = new System.Drawing.Size(180, 45);
            this.btnRealizarReseña.TabIndex = 41;
            this.btnRealizarReseña.Text = "Realizar Reseña";
            this.btnRealizarReseña.Click += new System.EventHandler(this.btnRealizarReseña_Click);
            // 
            // tbPuntuacion
            // 
            this.tbPuntuacion.Location = new System.Drawing.Point(542, 273);
            this.tbPuntuacion.Multiline = true;
            this.tbPuntuacion.Name = "tbPuntuacion";
            this.tbPuntuacion.Size = new System.Drawing.Size(59, 30);
            this.tbPuntuacion.TabIndex = 40;
            this.tbPuntuacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPuntuacion_KeyPress);
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Servicio al cliente",
            "Tiempo de llegada",
            "Opinión",
            "Calidad del producto"});
            this.cbCategoria.Location = new System.Drawing.Point(451, 149);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(251, 21);
            this.cbCategoria.TabIndex = 38;
            // 
            // dgProductosXPedido
            // 
            this.dgProductosXPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductosXPedido.Location = new System.Drawing.Point(26, 121);
            this.dgProductosXPedido.Name = "dgProductosXPedido";
            this.dgProductosXPedido.ReadOnly = true;
            this.dgProductosXPedido.Size = new System.Drawing.Size(395, 268);
            this.dgProductosXPedido.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(688, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 95);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDescripcion.Location = new System.Drawing.Point(451, 201);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(251, 64);
            this.tbDescripcion.TabIndex = 44;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(26, 71);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(154, 26);
            this.guna2HtmlLabel1.TabIndex = 52;
            this.guna2HtmlLabel1.Text = "Realizar reseña:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(451, 121);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(76, 22);
            this.guna2HtmlLabel2.TabIndex = 53;
            this.guna2HtmlLabel2.Text = "Categoría:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(451, 176);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(89, 22);
            this.guna2HtmlLabel3.TabIndex = 54;
            this.guna2HtmlLabel3.Text = "Comentario:";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(451, 279);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(87, 22);
            this.guna2HtmlLabel4.TabIndex = 55;
            this.guna2HtmlLabel4.Text = "Puntuación:";
            // 
            // FormPantallaRegistroReseñaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRealizarReseña);
            this.Controls.Add(this.tbPuntuacion);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.dgProductosXPedido);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormPantallaRegistroReseñaCliente";
            this.Text = "Reseña";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPantallaRegistroReseñaCliente_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductosXPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSalir;
        private Guna.UI2.WinForms.Guna2Button btnRealizarReseña;
        private System.Windows.Forms.TextBox tbPuntuacion;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.DataGridView dgProductosXPedido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbDescripcion;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
    }
}