using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using tfgEscritorio.apiHelper;
using tfgEscritorio.modelo;

namespace tfgEscritorio
{
    public partial class ProductoFrm : Form
    {

        private Producto producto;

        public ProductoFrm()
        {
            InitializeComponent();
            producto = new Producto();
            cargarCombo();
            this.DialogResult = DialogResult.Cancel;

        }

        public ProductoFrm(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            this.DialogResult = DialogResult.Cancel;

            txtNombreProducto.Text = producto.nombre;
            txtPrecio.Text = Convert.ToString(producto.precio);
            cargarCombo();

        }

        private async void cargarCombo()
        {
            cmbCategoria.Items.Clear();

            string url = "http://localhost:8080/api/v1/categoria";

            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Categoria>(url, apiHelper.methodHttp.GET, null, true);


            if (oReply != null && oReply.StatusCode == "Accepted")
            {
                List<Categoria> categorias = (List<Categoria>)oReply.Data;
                cmbCategoria.Items.AddRange((Categoria[])categorias.ToArray());
                cmbCategoria.DisplayMember = "nombre";
                cmbCategoria.ValueMember = "id";

                if (producto.categoria != null)
                {
                    cmbCategoria.SelectedIndex = cmbCategoria.FindStringExact(producto.categoria.nombre);
                }
            }
            else
            {

            }

        }

        public bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNombreProducto.Text))
            {
                MessageBox.Show("El campo nombre de producto es obligatorio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombreProducto.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("El campo precio es obligatorio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrecio.Focus();
                return false;
            }
            if (Double.TryParse(txtPrecio.Text, out double precio))
            {
                if (precio < 0)
                {
                    MessageBox.Show("El campo precio no puede ser negativo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrecio.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("El campo precio debe tener el formato correcto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrecio.Focus();
                return false;
            }

            if (cmbCategoria.SelectedItem == null)
            {
                MessageBox.Show("El campo categoría no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbCategoria.Focus();
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos() == true)
            {
                producto.nombre = txtNombreProducto.Text;
                producto.precio = float.Parse(txtPrecio.Text);

                producto.categoria = (Categoria)cmbCategoria.SelectedItem;

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
