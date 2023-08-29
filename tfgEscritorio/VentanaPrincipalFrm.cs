using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tfgEscritorio.apiHelper;
using tfgEscritorio.modelo;
using tfgEscritorio.utils;

namespace tfgEscritorio
{
    public partial class VentanaPrincipalFrm : Form
    {
        public VentanaPrincipalFrm()
        {
            InitializeComponent();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult respuestaDialogo = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuestaDialogo == DialogResult.Yes)
            {
                Consumer.username = string.Empty;
                Consumer.password = string.Empty;
                FormProvider.VentanaPrincipal.Hide();
                FormProvider.Login.Show();
            }          
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductosFrm productos = new ProductosFrm();
            productos.MdiParent = this;
            productos.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriasFrm categorias = new CategoriasFrm();
            categorias.MdiParent = this;
            categorias.Show();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void camarerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CamarerosFrm camareros = new CamarerosFrm();
            camareros.MdiParent = this;
            camareros.Show();
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MesasFrm mesas = new MesasFrm();
            mesas.MdiParent = this;
            mesas.Show();
        }

        private void pedidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PedidosFrm pedidos = new PedidosFrm();
            pedidos.MdiParent = this;
            pedidos.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesFrm clientes = new ClientesFrm();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void administradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministradoresFrm administradores = new AdministradoresFrm();
            administradores.MdiParent = this;
            administradores.Show();
        }

        private void VentanaPrincipalFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Consumer.username = string.Empty; 
            Consumer.password = string.Empty;
            Application.Exit();
        }
    }
}
