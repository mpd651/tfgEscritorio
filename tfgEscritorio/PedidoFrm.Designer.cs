namespace tfgEscritorio
{
    partial class PedidoFrm
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
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtNumeroMesa = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCocina = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaApertura = new System.Windows.Forms.TextBox();
            this.txtFechaCierre = new System.Windows.Forms.TextBox();
            this.txtPagado = new System.Windows.Forms.TextBox();
            this.lstProductosPedido = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(136, 47);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(100, 20);
            this.txtImporte.TabIndex = 29;
            // 
            // txtNumeroMesa
            // 
            this.txtNumeroMesa.Location = new System.Drawing.Point(136, 17);
            this.txtNumeroMesa.Name = "txtNumeroMesa";
            this.txtNumeroMesa.ReadOnly = true;
            this.txtNumeroMesa.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroMesa.TabIndex = 28;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(206, 282);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCocina
            // 
            this.lblCocina.AutoSize = true;
            this.lblCocina.Location = new System.Drawing.Point(12, 84);
            this.lblCocina.Name = "lblCocina";
            this.lblCocina.Size = new System.Drawing.Size(44, 13);
            this.lblCocina.TabIndex = 25;
            this.lblCocina.Text = "Pagado";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(12, 50);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(42, 13);
            this.lblPrecio.TabIndex = 23;
            this.lblPrecio.Text = "Importe";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 13);
            this.lblNombre.TabIndex = 22;
            this.lblNombre.Text = "Número de mesa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Fecha de apertura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Fecha de cierre";
            // 
            // txtFechaApertura
            // 
            this.txtFechaApertura.Location = new System.Drawing.Point(360, 17);
            this.txtFechaApertura.Name = "txtFechaApertura";
            this.txtFechaApertura.ReadOnly = true;
            this.txtFechaApertura.Size = new System.Drawing.Size(124, 20);
            this.txtFechaApertura.TabIndex = 34;
            // 
            // txtFechaCierre
            // 
            this.txtFechaCierre.Location = new System.Drawing.Point(360, 46);
            this.txtFechaCierre.Name = "txtFechaCierre";
            this.txtFechaCierre.ReadOnly = true;
            this.txtFechaCierre.Size = new System.Drawing.Size(124, 20);
            this.txtFechaCierre.TabIndex = 35;
            // 
            // txtPagado
            // 
            this.txtPagado.Location = new System.Drawing.Point(136, 81);
            this.txtPagado.Name = "txtPagado";
            this.txtPagado.ReadOnly = true;
            this.txtPagado.Size = new System.Drawing.Size(100, 20);
            this.txtPagado.TabIndex = 36;
            // 
            // lstProductosPedido
            // 
            this.lstProductosPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProductosPedido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstProductosPedido.FullRowSelect = true;
            this.lstProductosPedido.GridLines = true;
            this.lstProductosPedido.HideSelection = false;
            this.lstProductosPedido.Location = new System.Drawing.Point(15, 134);
            this.lstProductosPedido.Name = "lstProductosPedido";
            this.lstProductosPedido.Size = new System.Drawing.Size(469, 142);
            this.lstProductosPedido.TabIndex = 37;
            this.lstProductosPedido.UseCompatibleStateImageBehavior = false;
            this.lstProductosPedido.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre Producto";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cantidad";
            this.columnHeader2.Width = 96;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hora";
            this.columnHeader3.Width = 128;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio";
            this.columnHeader4.Width = 111;
            // 
            // PedidoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 313);
            this.Controls.Add(this.lstProductosPedido);
            this.Controls.Add(this.txtPagado);
            this.Controls.Add(this.txtFechaCierre);
            this.Controls.Add(this.txtFechaApertura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtNumeroMesa);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblCocina);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Name = "PedidoFrm";
            this.Text = "Pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtNumeroMesa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCocina;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFechaApertura;
        private System.Windows.Forms.TextBox txtFechaCierre;
        private System.Windows.Forms.TextBox txtPagado;
        private System.Windows.Forms.ListView lstProductosPedido;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}