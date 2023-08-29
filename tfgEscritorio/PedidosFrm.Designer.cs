namespace tfgEscritorio
{
    partial class PedidosFrm
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
            this.components = new System.ComponentModel.Container();
            this.lstPedidos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsPedidos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPedidos
            // 
            this.lstPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstPedidos.ContextMenuStrip = this.cmsPedidos;
            this.lstPedidos.FullRowSelect = true;
            this.lstPedidos.GridLines = true;
            this.lstPedidos.HideSelection = false;
            this.lstPedidos.Location = new System.Drawing.Point(2, 1);
            this.lstPedidos.Name = "lstPedidos";
            this.lstPedidos.Size = new System.Drawing.Size(605, 212);
            this.lstPedidos.TabIndex = 8;
            this.lstPedidos.UseCompatibleStateImageBehavior = false;
            this.lstPedidos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Número de mesa";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Importe";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha de apertura";
            this.columnHeader3.Width = 168;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fecha de cierre";
            this.columnHeader4.Width = 152;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Pagado";
            this.columnHeader5.Width = 79;
            // 
            // cmsPedidos
            // 
            this.cmsPedidos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPedidoToolStripMenuItem,
            this.borrarPedidoToolStripMenuItem});
            this.cmsPedidos.Name = "contextMenuStrip1";
            this.cmsPedidos.Size = new System.Drawing.Size(147, 48);
            this.cmsPedidos.Opening += new System.ComponentModel.CancelEventHandler(this.cmsPedidos_Opening);
            // 
            // verPedidoToolStripMenuItem
            // 
            this.verPedidoToolStripMenuItem.Image = global::tfgEscritorio.Properties.Resources.buscar;
            this.verPedidoToolStripMenuItem.Name = "verPedidoToolStripMenuItem";
            this.verPedidoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.verPedidoToolStripMenuItem.Text = "Ver pedido";
            this.verPedidoToolStripMenuItem.Click += new System.EventHandler(this.verPedidoToolStripMenuItem_Click);
            // 
            // borrarPedidoToolStripMenuItem
            // 
            this.borrarPedidoToolStripMenuItem.Image = global::tfgEscritorio.Properties.Resources.action_Cancel_16xMD;
            this.borrarPedidoToolStripMenuItem.Name = "borrarPedidoToolStripMenuItem";
            this.borrarPedidoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.borrarPedidoToolStripMenuItem.Text = "Borrar pedido";
            this.borrarPedidoToolStripMenuItem.Click += new System.EventHandler(this.borrarPedidoToolStripMenuItem_Click);
            // 
            // PedidosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 211);
            this.Controls.Add(this.lstPedidos);
            this.Name = "PedidosFrm";
            this.Text = "Pedidos";
            this.cmsPedidos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstPedidos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ContextMenuStrip cmsPedidos;
        private System.Windows.Forms.ToolStripMenuItem verPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarPedidoToolStripMenuItem;
    }
}