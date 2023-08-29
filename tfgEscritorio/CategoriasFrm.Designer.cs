namespace tfgEscritorio
{
    partial class CategoriasFrm
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
            this.lstCategorias = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsCategorias = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevaCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCategorias.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCategorias
            // 
            this.lstCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCategorias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9});
            this.lstCategorias.ContextMenuStrip = this.cmsCategorias;
            this.lstCategorias.FullRowSelect = true;
            this.lstCategorias.GridLines = true;
            this.lstCategorias.HideSelection = false;
            this.lstCategorias.Location = new System.Drawing.Point(0, 0);
            this.lstCategorias.Name = "lstCategorias";
            this.lstCategorias.Size = new System.Drawing.Size(611, 186);
            this.lstCategorias.TabIndex = 1;
            this.lstCategorias.UseCompatibleStateImageBehavior = false;
            this.lstCategorias.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Nombre";
            this.columnHeader8.Width = 299;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Número de productos";
            this.columnHeader9.Width = 306;
            // 
            // cmsCategorias
            // 
            this.cmsCategorias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaCategoriaToolStripMenuItem,
            this.verCategoriaToolStripMenuItem,
            this.borrarCategoriaToolStripMenuItem});
            this.cmsCategorias.Name = "contextMenuStrip1";
            this.cmsCategorias.Size = new System.Drawing.Size(161, 70);
            this.cmsCategorias.Opening += new System.ComponentModel.CancelEventHandler(this.cmsCategorias_Opening);
            // 
            // nuevaCategoriaToolStripMenuItem
            // 
            this.nuevaCategoriaToolStripMenuItem.Image = global::tfgEscritorio.Properties.Resources.action_add_16xMD;
            this.nuevaCategoriaToolStripMenuItem.Name = "nuevaCategoriaToolStripMenuItem";
            this.nuevaCategoriaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.nuevaCategoriaToolStripMenuItem.Text = "Nueva categoría";
            this.nuevaCategoriaToolStripMenuItem.Click += new System.EventHandler(this.nuevaCategoriaToolStripMenuItem_Click);
            // 
            // verCategoriaToolStripMenuItem
            // 
            this.verCategoriaToolStripMenuItem.Image = global::tfgEscritorio.Properties.Resources.buscar;
            this.verCategoriaToolStripMenuItem.Name = "verCategoriaToolStripMenuItem";
            this.verCategoriaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.verCategoriaToolStripMenuItem.Text = "Ver categoría";
            this.verCategoriaToolStripMenuItem.Click += new System.EventHandler(this.verCategoriaToolStripMenuItem_Click);
            // 
            // borrarCategoriaToolStripMenuItem
            // 
            this.borrarCategoriaToolStripMenuItem.Image = global::tfgEscritorio.Properties.Resources.action_Cancel_16xMD;
            this.borrarCategoriaToolStripMenuItem.Name = "borrarCategoriaToolStripMenuItem";
            this.borrarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.borrarCategoriaToolStripMenuItem.Text = "Borrar categoría";
            this.borrarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.borrarCategoriaToolStripMenuItem_Click);
            // 
            // CategoriasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 184);
            this.Controls.Add(this.lstCategorias);
            this.Name = "CategoriasFrm";
            this.Text = "Categorias";
            this.cmsCategorias.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstCategorias;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ContextMenuStrip cmsCategorias;
        private System.Windows.Forms.ToolStripMenuItem nuevaCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarCategoriaToolStripMenuItem;
    }
}