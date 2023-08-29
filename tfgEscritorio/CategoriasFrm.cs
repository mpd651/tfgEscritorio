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

namespace tfgEscritorio
{
    public partial class CategoriasFrm : Form
    {
        public CategoriasFrm()
        {
            InitializeComponent();
            RefrescarLista();
        }

        private async void RefrescarLista()
        {
            lstCategorias.Items.Clear();

            string url = "http://localhost:8080/api/v1/categoria";

            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Categoria>(url, apiHelper.methodHttp.GET, null, true);


            if (oReply != null && oReply.StatusCode == "Accepted")
            {
                List<Categoria> categorias = (List<Categoria>)oReply.Data;

                foreach (Categoria categoria in categorias)
                {
                    url = "http://localhost:8080/api/v1/producto/categoria/categoriaId?categoriaId=" + categoria.id;
                    oReply = await Consumer.Execute<Producto>(url, apiHelper.methodHttp.GET, null, true);
                    List<Producto> productos = (List<Producto>)oReply.Data;

                    ListViewItem fila = new ListViewItem(new string[] { categoria.nombre, Convert.ToString(productos.Count)});
                    fila.Tag = categoria.id;
                    lstCategorias.Items.Add(fila);
                }
            }
            else
            {

            }

        }

        private void nuevaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            CategoriaFrm propiedadesCategoria = new CategoriaFrm(categoria);
            if (propiedadesCategoria.ShowDialog() == DialogResult.OK)
            {
                crearObjeto(categoria);
            }
        }

        private async void crearObjeto(Categoria categoria)
        {
            string url = "http://localhost:8080/api/v1/categoria";

            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Categoria>(url, apiHelper.methodHttp.POST, categoria, false);

            RefrescarLista();
        }

        private void verCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria categoria = buscarObjeto((int)lstCategorias.SelectedItems[0].Tag).Result;

            CategoriaFrm propiedadesCategoria = new CategoriaFrm(categoria);

            if (propiedadesCategoria.ShowDialog() == DialogResult.OK)
            {
                actualizarObjeto(categoria);
            }
        }

        private async Task<Categoria> buscarObjeto(int id)
        {
            string url = "http://localhost:8080/api/v1/categoria/id?id=" + id;

            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Categoria>(url, apiHelper.methodHttp.GET, null, false).ConfigureAwait(false);

            return (Categoria)oReply.Data;
        }

        private async void actualizarObjeto(Categoria categoria)
        {
            string url = "http://localhost:8080/api/v1/categoria/modificar?id=" + categoria.id;
            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Categoria>(url, apiHelper.methodHttp.PUT, categoria, false);

            RefrescarLista();
        }

        private void borrarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuestaDialogo = MessageBox.Show("¿Desea eliminar el producto seleccionado?", "Borrar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuestaDialogo == DialogResult.Yes)
            {
                Categoria categoria = buscarObjeto((int)lstCategorias.SelectedItems[0].Tag).Result;
                borrarObjeto(categoria);
            }
        }

        private async void borrarObjeto(Categoria categoria)
        {
            string url = "http://localhost:8080/api/v1/categoria/eliminar?id=" + categoria.id;
            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Categoria>(url, apiHelper.methodHttp.DELETE, categoria, false);

            RefrescarLista();
        }

        private void cmsCategorias_Opening(object sender, CancelEventArgs e)
        {
            this.verCategoriaToolStripMenuItem.Enabled = false;
            this.borrarCategoriaToolStripMenuItem.Enabled = false;
            if (lstCategorias.SelectedItems.Count == 1)
            {
                this.verCategoriaToolStripMenuItem.Enabled = true;
                this.borrarCategoriaToolStripMenuItem.Enabled = true;
            }
        }
    }
}
