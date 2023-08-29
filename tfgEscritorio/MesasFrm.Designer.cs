namespace tfgEscritorio
{
    partial class MesasFrm
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
            this.lstMesas = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsMesas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevaMesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarMesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMesas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMesas
            // 
            this.lstMesas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMesas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.lstMesas.ContextMenuStrip = this.cmsMesas;
            this.lstMesas.FullRowSelect = true;
            this.lstMesas.GridLines = true;
            this.lstMesas.HideSelection = false;
            this.lstMesas.Location = new System.Drawing.Point(-1, 0);
            this.lstMesas.Name = "lstMesas";
            this.lstMesas.Size = new System.Drawing.Size(611, 186);
            this.lstMesas.TabIndex = 11;
            this.lstMesas.UseCompatibleStateImageBehavior = false;
            this.lstMesas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Número de mesa";
            this.columnHeader4.Width = 605;
            // 
            // cmsMesas
            // 
            this.cmsMesas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaMesaToolStripMenuItem,
            this.verMesaToolStripMenuItem,
            this.borrarMesaToolStripMenuItem});
            this.cmsMesas.Name = "contextMenuStrip1";
            this.cmsMesas.Size = new System.Drawing.Size(140, 70);
            this.cmsMesas.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMesas_Opening);
            // 
            // nuevaMesaToolStripMenuItem
            // 
            this.nuevaMesaToolStripMenuItem.Image = global::tfgEscritorio.Properties.Resources.action_add_16xMD;
            this.nuevaMesaToolStripMenuItem.Name = "nuevaMesaToolStripMenuItem";
            this.nuevaMesaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.nuevaMesaToolStripMenuItem.Text = "Nueva mesa";
            this.nuevaMesaToolStripMenuItem.Click += new System.EventHandler(this.nuevaMesaToolStripMenuItem_Click);
            // 
            // verMesaToolStripMenuItem
            // 
            this.verMesaToolStripMenuItem.Image = global::tfgEscritorio.Properties.Resources.buscar;
            this.verMesaToolStripMenuItem.Name = "verMesaToolStripMenuItem";
            this.verMesaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.verMesaToolStripMenuItem.Text = "Ver mesa";
            this.verMesaToolStripMenuItem.Click += new System.EventHandler(this.verMesaToolStripMenuItem_Click);
            // 
            // borrarMesaToolStripMenuItem
            // 
            this.borrarMesaToolStripMenuItem.Image = global::tfgEscritorio.Properties.Resources.action_Cancel_16xMD;
            this.borrarMesaToolStripMenuItem.Name = "borrarMesaToolStripMenuItem";
            this.borrarMesaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.borrarMesaToolStripMenuItem.Text = "Borrar mesa";
            this.borrarMesaToolStripMenuItem.Click += new System.EventHandler(this.borrarMesaToolStripMenuItem_Click);
            // 
            // MesasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 184);
            this.Controls.Add(this.lstMesas);
            this.Name = "MesasFrm";
            this.Text = "Mesas";
            this.cmsMesas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstMesas;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip cmsMesas;
        private System.Windows.Forms.ToolStripMenuItem nuevaMesaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMesaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarMesaToolStripMenuItem;
    }
}