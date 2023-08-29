namespace tfgEscritorio
{
    partial class AdministradoresFrm
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
            this.lstAdministradores = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsAdministradores = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAdministradores.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAdministradores
            // 
            this.lstAdministradores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAdministradores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstAdministradores.ContextMenuStrip = this.cmsAdministradores;
            this.lstAdministradores.FullRowSelect = true;
            this.lstAdministradores.GridLines = true;
            this.lstAdministradores.HideSelection = false;
            this.lstAdministradores.Location = new System.Drawing.Point(-1, 1);
            this.lstAdministradores.Name = "lstAdministradores";
            this.lstAdministradores.Size = new System.Drawing.Size(611, 184);
            this.lstAdministradores.TabIndex = 11;
            this.lstAdministradores.UseCompatibleStateImageBehavior = false;
            this.lstAdministradores.View = System.Windows.Forms.View.Details;
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
            // cmsAdministradores
            // 
            this.cmsAdministradores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoAdministradorToolStripMenuItem,
            this.verAdministradorToolStripMenuItem,
            this.borrarAdministradorToolStripMenuItem,
            this.restaurarContraseñaToolStripMenuItem});
            this.cmsAdministradores.Name = "contextMenuStrip1";
            this.cmsAdministradores.Size = new System.Drawing.Size(187, 92);
            this.cmsAdministradores.Opening += new System.ComponentModel.CancelEventHandler(this.cmsAdministradores_Opening);
            // 
            // nuevoAdministradorToolStripMenuItem
            // 
            this.nuevoAdministradorToolStripMenuItem.Image = global::tfgEscritorio.Properties.Resources.action_add_16xMD;
            this.nuevoAdministradorToolStripMenuItem.Name = "nuevoAdministradorToolStripMenuItem";
            this.nuevoAdministradorToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.nuevoAdministradorToolStripMenuItem.Text = "Nuevo administrador";
            this.nuevoAdministradorToolStripMenuItem.Click += new System.EventHandler(this.nuevoCamareroToolStripMenuItem_Click);
            // 
            // verAdministradorToolStripMenuItem
            // 
            this.verAdministradorToolStripMenuItem.Image = global::tfgEscritorio.Properties.Resources.buscar;
            this.verAdministradorToolStripMenuItem.Name = "verAdministradorToolStripMenuItem";
            this.verAdministradorToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.verAdministradorToolStripMenuItem.Text = "Ver administrador";
            this.verAdministradorToolStripMenuItem.Click += new System.EventHandler(this.verCamareroToolStripMenuItem_Click);
            // 
            // borrarAdministradorToolStripMenuItem
            // 
            this.borrarAdministradorToolStripMenuItem.Image = global::tfgEscritorio.Properties.Resources.action_Cancel_16xMD;
            this.borrarAdministradorToolStripMenuItem.Name = "borrarAdministradorToolStripMenuItem";
            this.borrarAdministradorToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.borrarAdministradorToolStripMenuItem.Text = "Borrar administrador";
            this.borrarAdministradorToolStripMenuItem.Click += new System.EventHandler(this.borrarCamareroToolStripMenuItem_Click);
            // 
            // restaurarContraseñaToolStripMenuItem
            // 
            this.restaurarContraseñaToolStripMenuItem.Image = global::tfgEscritorio.Properties.Resources.Undo_16x;
            this.restaurarContraseñaToolStripMenuItem.Name = "restaurarContraseñaToolStripMenuItem";
            this.restaurarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.restaurarContraseñaToolStripMenuItem.Text = "Restaurar contraseña";
            this.restaurarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.restaurarContraseñaToolStripMenuItem_Click);
            // 
            // AdministradoresFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 184);
            this.Controls.Add(this.lstAdministradores);
            this.Name = "AdministradoresFrm";
            this.Text = "Administradores";
            this.cmsAdministradores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstAdministradores;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip cmsAdministradores;
        private System.Windows.Forms.ToolStripMenuItem nuevoAdministradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAdministradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarAdministradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarContraseñaToolStripMenuItem;
    }
}