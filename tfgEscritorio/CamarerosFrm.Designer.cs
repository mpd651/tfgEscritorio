namespace tfgEscritorio
{
    partial class CamarerosFrm
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
            this.lstCamareros = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsCamareros = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoCamareroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCamareroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarCamareroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCamareros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCamareros
            // 
            this.lstCamareros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCamareros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstCamareros.ContextMenuStrip = this.cmsCamareros;
            this.lstCamareros.FullRowSelect = true;
            this.lstCamareros.GridLines = true;
            this.lstCamareros.HideSelection = false;
            this.lstCamareros.Location = new System.Drawing.Point(0, -1);
            this.lstCamareros.Name = "lstCamareros";
            this.lstCamareros.Size = new System.Drawing.Size(611, 190);
            this.lstCamareros.TabIndex = 10;
            this.lstCamareros.UseCompatibleStateImageBehavior = false;
            this.lstCamareros.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Usuario";
            this.columnHeader1.Width = 187;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 209;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apellidos";
            this.columnHeader3.Width = 211;
            // 
            // cmsCamareros
            // 
            this.cmsCamareros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoCamareroToolStripMenuItem,
            this.verCamareroToolStripMenuItem,
            this.borrarCamareroToolStripMenuItem,
            this.restaurarContraseñaToolStripMenuItem});
            this.cmsCamareros.Name = "contextMenuStrip1";
            this.cmsCamareros.Size = new System.Drawing.Size(185, 92);
            this.cmsCamareros.Opening += new System.ComponentModel.CancelEventHandler(this.cmsCamareros_Opening);
            // 
            // nuevoCamareroToolStripMenuItem
            // 
            this.nuevoCamareroToolStripMenuItem.Image = global::tfgEscritorio.Properties.Resources.action_add_16xMD;
            this.nuevoCamareroToolStripMenuItem.Name = "nuevoCamareroToolStripMenuItem";
            this.nuevoCamareroToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.nuevoCamareroToolStripMenuItem.Text = "Nuevo Camarero";
            this.nuevoCamareroToolStripMenuItem.Click += new System.EventHandler(this.nuevoCamareroToolStripMenuItem_Click);
            // 
            // verCamareroToolStripMenuItem
            // 
            this.verCamareroToolStripMenuItem.Image = global::tfgEscritorio.Properties.Resources.buscar;
            this.verCamareroToolStripMenuItem.Name = "verCamareroToolStripMenuItem";
            this.verCamareroToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.verCamareroToolStripMenuItem.Text = "Ver camarero";
            this.verCamareroToolStripMenuItem.Click += new System.EventHandler(this.verCamareroToolStripMenuItem_Click);
            // 
            // borrarCamareroToolStripMenuItem
            // 
            this.borrarCamareroToolStripMenuItem.Image = global::tfgEscritorio.Properties.Resources.action_Cancel_16xMD;
            this.borrarCamareroToolStripMenuItem.Name = "borrarCamareroToolStripMenuItem";
            this.borrarCamareroToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.borrarCamareroToolStripMenuItem.Text = "Borrar camarero";
            this.borrarCamareroToolStripMenuItem.Click += new System.EventHandler(this.borrarCamareroToolStripMenuItem_Click);
            // 
            // restaurarContraseñaToolStripMenuItem
            // 
            this.restaurarContraseñaToolStripMenuItem.Image = global::tfgEscritorio.Properties.Resources.Undo_16x;
            this.restaurarContraseñaToolStripMenuItem.Name = "restaurarContraseñaToolStripMenuItem";
            this.restaurarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.restaurarContraseñaToolStripMenuItem.Text = "Restaurar contraseña";
            this.restaurarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.restaurarContraseñaToolStripMenuItem_Click);
            // 
            // CamarerosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 184);
            this.Controls.Add(this.lstCamareros);
            this.Name = "CamarerosFrm";
            this.Text = "Camareros";
            this.cmsCamareros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lstCamareros;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip cmsCamareros;
        private System.Windows.Forms.ToolStripMenuItem nuevoCamareroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCamareroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarCamareroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarContraseñaToolStripMenuItem;
    }
}