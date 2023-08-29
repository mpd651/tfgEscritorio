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
    public partial class CamareroFrm : Form
    {

        private Usuario camarero;

        public CamareroFrm()
        {
            InitializeComponent();
        }

        public CamareroFrm(Usuario camarero)
        {
            InitializeComponent();
            this.camarero = camarero;
            this.DialogResult = DialogResult.Cancel;

            txtNombre.Text = camarero.nombre;
            txtApellidos.Text = camarero.apellidos;
            txtUsuario.Text = camarero.userName;
        }

        public bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo nombre es obligatorio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("El campo usuario es obligatorio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos() == true)
            {
                camarero.userName = txtUsuario.Text;
                camarero.nombre = txtNombre.Text;
                camarero.apellidos = txtApellidos.Text;
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
