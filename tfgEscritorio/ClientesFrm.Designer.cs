namespace tfgEscritorio
{
    partial class ClientesFrm
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
            this.lstClientes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsClientes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.borrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstClientes
            // 
            this.lstClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstClientes.ContextMenuStrip = this.cmsClientes;
            this.lstClientes.FullRowSelect = true;
            this.lstClientes.GridLines = true;
            this.lstClientes.HideSelection = false;
            this.lstClientes.Location = new System.Drawing.Point(0, -1);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(611, 186);
            this.lstClientes.TabIndex = 11;
            this.lstClientes.UseCompatibleStateImageBehavior = false;
            this.lstClientes.View = System.Windows.Forms.View.Details;
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
            // cmsClientes
            // 
            this.cmsClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarClienteToolStripMenuItem,
            this.restaurarContraseñaToolStripMenuItem});
            this.cmsClientes.Name = "contextMenuStrip1";
            this.cmsClientes.Size = new System.Drawing.Size(185, 48);
            this.cmsClientes.Opening += new System.ComponentModel.CancelEventHandler(this.cmsClientes_Opening);
            // 
            // borrarClienteToolStripMenuItem
            // 
            this.borrarClienteToolStripMenuItem.Image = global::tfgEscritorio.Properties.Resources.action_Cancel_16xMD;
            this.borrarClienteToolStripMenuItem.Name = "borrarClienteToolStripMenuItem";
            this.borrarClienteToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.borrarClienteToolStripMenuItem.Text = "Borrar cliente";
            this.borrarClienteToolStripMenuItem.Click += new System.EventHandler(this.borrarClienteToolStripMenuItem_Click);
            // 
            // restaurarContraseñaToolStripMenuItem
            // 
            this.restaurarContraseñaToolStripMenuItem.Image = global::tfgEscritorio.Properties.Resources.Undo_16x;
            this.restaurarContraseñaToolStripMenuItem.Name = "restaurarContraseñaToolStripMenuItem";
            this.restaurarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.restaurarContraseñaToolStripMenuItem.Text = "Restaurar contraseña";
            this.restaurarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.restaurarContraseñaToolStripMenuItem_Click);
            // 
            // ClientesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 184);
            this.Controls.Add(this.lstClientes);
            this.Name = "ClientesFrm";
            this.Text = "Clientes";
            this.cmsClientes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstClientes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip cmsClientes;
        private System.Windows.Forms.ToolStripMenuItem borrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarContraseñaToolStripMenuItem;
    }
}