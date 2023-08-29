using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tfgEscritorio.modelo;

namespace tfgEscritorio
{
    public partial class CategoriaFrm : Form
    {

        private Categoria categoria;

        public CategoriaFrm()
        {
            InitializeComponent();
            categoria = new Categoria();
            this.DialogResult = DialogResult.Cancel;
        }

        public CategoriaFrm(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            this.DialogResult = DialogResult.Cancel;

            txtNombre.Text = categoria.nombre;
        }

        public bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo nombre de categoría es obligatorio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos() == true)
            {
                categoria.nombre = txtNombre.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
