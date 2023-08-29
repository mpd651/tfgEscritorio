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
    public partial class CamarerosFrm : Form
    {
        public CamarerosFrm()
        {
            InitializeComponent();
            RefrescarLista();
        }

        private async void RefrescarLista()
        {
            lstCamareros.Items.Clear();
            string url = "http://localhost:8080/api/v1/usuario/lista?rol=CAMARERO";

            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Usuario>(url, apiHelper.methodHttp.GET, null, true);


            if (oReply != null && oReply.StatusCode == "Accepted")
            {
                List<Usuario> usuarios = (List<Usuario>)oReply.Data;

                foreach (Usuario usuario in usuarios)
                {
                    ListViewItem fila = new ListViewItem (new string[] {usuario.userName ,usuario.nombre, usuario.apellidos});
                    fila.Tag = usuario.id;
                    lstCamareros.Items.Add(fila);
                }
            }
            else
            {

            }

        }

        private void nuevoCamareroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario camarero = new Usuario();
            camarero.rol = "CAMARERO";
            CamareroFrm propiedadesCamarero = new CamareroFrm(camarero);
            if (propiedadesCamarero.ShowDialog() == DialogResult.OK)
            {
                crearObjeto(camarero);
            }
        }

        private async void crearObjeto(Usuario usuario)
        {
            string url = "http://localhost:8080/api/v1/usuario/registrar";

            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Usuario>(url, apiHelper.methodHttp.POST, usuario, false);

            RefrescarLista();
        }

        private void verCamareroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario camarero = buscarObjeto((int)lstCamareros.SelectedItems[0].Tag).Result;

            CamareroFrm propiedadesCamarero = new CamareroFrm(camarero);

            if (propiedadesCamarero.ShowDialog() == DialogResult.OK)
            {
                actualizarObjeto(camarero);
            }

        }

        private async Task<Usuario> buscarObjeto(int id)
        {
            string url = "http://localhost:8080/api/v1/usuario/id?id=" + id;

            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Usuario>(url, apiHelper.methodHttp.GET, null, false).ConfigureAwait(false);

            return (Usuario)oReply.Data;
        }

        private async void actualizarObjeto(Usuario camarero)
        {
            string url = "http://localhost:8080/api/v1/usuario/modificar?id=" + camarero.id;
            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Usuario>(url, apiHelper.methodHttp.PUT, camarero, false);

            RefrescarLista();
        }

        private void borrarCamareroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuestaDialogo = MessageBox.Show("¿Desea eliminar el camarero seleccionado?", "Borrar camarero", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuestaDialogo == DialogResult.Yes)
            {
                Usuario usuario = buscarObjeto((int)lstCamareros.SelectedItems[0].Tag).Result;
                borrarObjeto(usuario);
            }
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
            DialogResult respuestaDialogo = MessageBox.Show("¿Desea restaurar la contraseña del camarero seleccionado?", "Restaurar contraseña", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuestaDialogo == DialogResult.Yes)
            {
                Usuario usuario = buscarObjeto((int)lstCamareros.SelectedItems[0].Tag).Result;
                usuario.password = null;
                actualizarObjeto(usuario);
            }
        }

        private void cmsCamareros_Opening(object sender, CancelEventArgs e)
        {
            this.verCamareroToolStripMenuItem.Enabled = false;
            this.borrarCamareroToolStripMenuItem.Enabled = false;
            this.restaurarContraseñaToolStripMenuItem.Enabled = false;
            if (lstCamareros.SelectedItems.Count == 1)
            {
                this.verCamareroToolStripMenuItem.Enabled = true;
                this.borrarCamareroToolStripMenuItem.Enabled = true;
                this.restaurarContraseñaToolStripMenuItem.Enabled = true;

            }
        }
    }
}
