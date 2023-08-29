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
    public partial class MesaFrm : Form
    {
        private Mesa mesa;

        public MesaFrm()
        {
            InitializeComponent();
        }

        public MesaFrm(Mesa mesa)
        {
            InitializeComponent();
            this.mesa = mesa;
            this.DialogResult = DialogResult.Cancel;

            txtNumero.Text = Convert.ToString(mesa.numeroMesa);
        }

        public bool ValidarDatos()
        {
            
            if (Int32.TryParse(txtNumero.Text, out Int32 num))
            {
                if (num < 0)
                {
                    MessageBox.Show("El campo número de mesa no puede ser negativo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumero.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("El campo número de mesa debe tener el formato correcto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumero.Focus();
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos() == true)
            {
                mesa.numeroMesa = Convert.ToInt32(txtNumero.Text);
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
