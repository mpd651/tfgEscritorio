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
using tfgEscritorio.dto;
using tfgEscritorio.modelo;
using tfgEscritorio.utils;

namespace tfgEscritorio
{
    public partial class ProductosFrm : Form
    {
        public ProductosFrm()
        {
            InitializeComponent();
            RefrescarLista();
        }


        private async void RefrescarLista()
        {
            lstProdutos.Items.Clear();

            string url = "http://localhost:8080/api/v1/producto";

            Reply oReply = new Reply();

            oReply = await Consumer.Execute<ProductoDto>(url, apiHelper.methodHttp.GET, null, true);


            if (oReply != null && oReply.StatusCode == "Accepted")
            {
                List<ProductoDto> productos = (List<ProductoDto>)oReply.Data;

                foreach (ProductoDto producto in productos)
                {
                    ListViewItem fila = new ListViewItem(new string[] { producto.nombre, producto.categoria.nombre, Convert.ToString(producto.precio) });
                    fila.Tag = producto.id;
                    lstProdutos.Items.Add(fila);
                }
            }
            else
            {
                
            }

        }

        private async void crearObjeto(Producto producto)
        {
            string url = "http://localhost:8080/api/v1/producto";

            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Producto>(url, apiHelper.methodHttp.POST, producto, false);

            RefrescarLista();
        }

        private async Task<ProductoDto> buscarObjeto(int id)
        {
            string url = "http://localhost:8080/api/v1/producto/id?id="+ id;

            Reply oReply = new Reply();

            oReply = await Consumer.Execute<ProductoDto>(url, apiHelper.methodHttp.GET, null, false).ConfigureAwait(false);

            return (ProductoDto)oReply.Data;
        }

        private async void actualizarObjeto(Producto producto)
        {
            string url = "http://localhost:8080/api/v1/producto/modificar?id=" + producto.id;
            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Producto>(url, apiHelper.methodHttp.PUT, producto, false);

            RefrescarLista();
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            ProductoFrm propiedadesProducto = new ProductoFrm(producto);
            if (propiedadesProducto.ShowDialog() == DialogResult.OK)
            {
                crearObjeto(producto);
            }
        }

        private void verProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductoDto dto = buscarObjeto((int)lstProdutos.SelectedItems[0].Tag).Result;

            Producto producto = new Producto();
            producto.id = dto.id;
            producto.precio = dto.precio;
            producto.nombre = dto.nombre; 
            
            ProductoFrm propiedadesProducto = new ProductoFrm(producto);

            if (propiedadesProducto.ShowDialog() == DialogResult.OK)
            {
                actualizarObjeto(producto);
            }
        }

        private async void borrarObjeto(Producto producto)
        {
            string url = "http://localhost:8080/api/v1/producto/eliminar?id=" + producto.id;
            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Producto>(url, apiHelper.methodHttp.DELETE, producto, false);

            RefrescarLista();
        }

        private void borrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuestaDialogo = MessageBox.Show("¿Desea eliminar el producto seleccionado?", "Borrar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuestaDialogo == DialogResult.Yes)
            {
                ProductoDto dto = buscarObjeto((int)lstProdutos.SelectedItems[0].Tag).Result;
                Producto producto = new Producto();
                producto.id = dto.id;
                borrarObjeto(producto);
            }
        }

        private void cmsProductos_Opening(object sender, CancelEventArgs e)
        {
            this.verProductoToolStripMenuItem.Enabled = false;
            this.borrarProductoToolStripMenuItem.Enabled = false;
            if (lstProdutos.SelectedItems.Count == 1)
            {
                this.verProductoToolStripMenuItem.Enabled = true;
                this.borrarProductoToolStripMenuItem.Enabled = true;
            }
        }
    }
}
