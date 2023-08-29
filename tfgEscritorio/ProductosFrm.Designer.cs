namespace tfgEscritorio
{
    partial class ProductosFrm
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
            this.lstProdutos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsProductos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstProdutos
            // 
            this.lstProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstProdutos.ContextMenuStrip = this.cmsProductos;
            this.lstProdutos.FullRowSelect = true;
            this.lstProdutos.GridLines = true;
            this.lstProdutos.HideSelection = false;
            this.lstProdutos.Location = new System.Drawing.Point(0, 2);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(605, 208);
            this.lstProdutos.TabIndex = 7;
            this.lstProdutos.UseCompatibleStateImageBehavior = false;
            this.lstProdutos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 173;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre categoría";
            this.columnHeader2.Width = 203;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precio";
            this.columnHeader3.Width = 174;
            // 
            // cmsProductos
            // 
            this.cmsProductos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProductoToolStripMenuItem,
            this.verProductoToolStripMenuItem,
            this.borrarProductoToolStripMenuItem});
            this.cmsProductos.Name = "contextMenuStrip1";
            this.cmsProductos.Size = new System.Drawing.Size(159, 70);
            this.cmsProductos.Opening += new System.ComponentModel.CancelEventHandler(this.cmsProductos_Opening);
            // 
            // nuevoProductoToolStripMenuItem
            // 
            this.nuevoProductoToolStripMenuItem.Image = global::tfgEscritorio.Properties.Resources.action_add_16xMD;
            this.nuevoProductoToolStripMenuItem.Name = "nuevoProductoToolStripMenuItem";
            this.nuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoProductoToolStripMenuItem.Text = "Nuevo produto";
            this.nuevoProductoToolStripMenuItem.Click += new System.EventHandler(this.nuevoProductoToolStripMenuItem_Click);
            // 
            // verProductoToolStripMenuItem
            // 
            this.verProductoToolStripMenuItem.Image = global::tfgEscritorio.Properties.Resources.buscar;
            this.verProductoToolStripMenuItem.Name = "verProductoToolStripMenuItem";
            this.verProductoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verProductoToolStripMenuItem.Text = "Ver producto";
            this.verProductoToolStripMenuItem.Click += new System.EventHandler(this.verProductoToolStripMenuItem_Click);
            // 
            // borrarProductoToolStripMenuItem
            // 
            this.borrarProductoToolStripMenuItem.Image = global::tfgEscritorio.Properties.Resources.action_Cancel_16xMD;
            this.borrarProductoToolStripMenuItem.Name = "borrarProductoToolStripMenuItem";
            this.borrarProductoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borrarProductoToolStripMenuItem.Text = "Borrar producto";
            this.borrarProductoToolStripMenuItem.Click += new System.EventHandler(this.borrarProductoToolStripMenuItem_Click);
            // 
            // ProductosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 211);
            this.Controls.Add(this.lstProdutos);
            this.Name = "ProductosFrm";
            this.Text = "Productos";
            this.cmsProductos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lstProdutos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip cmsProductos;
        private System.Windows.Forms.ToolStripMenuItem nuevoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarProductoToolStripMenuItem;
    }
}