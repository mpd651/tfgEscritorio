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
    public partial class ClientesFrm : Form
    {
        public ClientesFrm()
        {
            InitializeComponent();
            RefrescarLista();
        }

        private async void RefrescarLista()
        {
            lstClientes.Items.Clear();
            string url = "http://localhost:8080/api/v1/usuario/lista?rol=CLIENTE";

            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Usuario>(url, apiHelper.methodHttp.GET, null, true);


            if (oReply != null && oReply.StatusCode == "Accepted")
            {
                List<Usuario> usuarios = (List<Usuario>)oReply.Data;

                foreach (Usuario usuario in usuarios)
                {
                    ListViewItem fila = new ListViewItem(new string[] { usuario.userName, usuario.nombre, usuario.apellidos });
                    fila.Tag = usuario.id;
                    lstClientes.Items.Add(fila);
                }
            }
            else
            {

            }

        }

        private void borrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuestaDialogo = MessageBox.Show("¿Desea eliminar el cliente seleccionado?", "Borrar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuestaDialogo == DialogResult.Yes)
            {
                Usuario usuario = buscarObjeto((int)lstClientes.SelectedItems[0].Tag).Result;
                borrarObjeto(usuario);
            }
        }

        private async Task<Usuario> buscarObjeto(int id)
        {
            string url = "http://localhost:8080/api/v1/usuario/id?id=" + id;

            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Usuario>(url, apiHelper.methodHttp.GET, null, false).ConfigureAwait(false);

            return (Usuario)oReply.Data;
        }

        private async void borrarObjeto(Usuario usuario)
        {
            string url = "http://localhost:8080/api/v1/usuario/eliminar?id=" + usuario.id;
            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Usuario>(url, apiHelper.methodHttp.DELETE, usuario, false);

            RefrescarLista();
        }

        private void restaurarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuestaDialogo = MessageBox.Show("¿Desea restaurar la contraseña del cliente seleccionado?", "Restaurar contraseña", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuestaDialogo == DialogResult.Yes)
            {
                Usuario usuario = buscarObjeto((int)lstClientes.SelectedItems[0].Tag).Result;
                usuario.password = null;
                actualizarObjeto(usuario);
            }
        }

        private async void actualizarObjeto(Usuario usuario)
        {
            string url = "http://localhost:8080/api/v1/usuario/modificar?id=" + usuario.id;
            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Usuario>(url, apiHelper.methodHttp.PUT, usuario, false);

            RefrescarLista();
        }

        private void cmsClientes_Opening(object sender, CancelEventArgs e)
        {
            this.borrarClienteToolStripMenuItem.Enabled = false;
            this.restaurarContraseñaToolStripMenuItem.Enabled = false;
            if (lstClientes.SelectedItems.Count == 1)
            {
                this.borrarClienteToolStripMenuItem.Enabled = true;
                this.restaurarContraseñaToolStripMenuItem.Enabled = true;

            }
        }
    }
}
