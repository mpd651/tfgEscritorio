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
    public partial class AdministradoresFrm : Form
    {
        public AdministradoresFrm()
        {
            InitializeComponent();
            RefrescarLista();
        }

        private async void RefrescarLista()
        {
            lstAdministradores.Items.Clear();
            string url = "http://localhost:8080/api/v1/usuario/lista?rol=ADMINISTRADOR";

            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Usuario>(url, apiHelper.methodHttp.GET, null, true);


            if (oReply != null && oReply.StatusCode == "Accepted")
            {
                List<Usuario> usuarios = (List<Usuario>)oReply.Data;

                foreach (Usuario usuario in usuarios)
                {
                    ListViewItem fila = new ListViewItem(new string[] { usuario.userName, usuario.nombre, usuario.apellidos });
                    fila.Tag = usuario.id;
                    lstAdministradores.Items.Add(fila);
                }
            }
            else
            {

            }

        }

        private void nuevoCamareroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.rol = "ADMINISTRADOR";
            CamareroFrm propiedadesUsuario = new CamareroFrm(usuario);
            if (propiedadesUsuario.ShowDialog() == DialogResult.OK)
            {
                crearObjeto(usuario);
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
            Usuario usuario = buscarObjeto((int)lstAdministradores.SelectedItems[0].Tag).Result;

            CamareroFrm propiedadesUsuario = new CamareroFrm(usuario);

            if (propiedadesUsuario.ShowDialog() == DialogResult.OK)
            {
                actualizarObjeto(usuario);
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
            DialogResult respuestaDialogo = MessageBox.Show("¿Desea eliminar el administrador seleccionado?", "Borrar administrador", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuestaDialogo == DialogResult.Yes)
            {
                Usuario usuario = buscarObjeto((int)lstAdministradores.SelectedItems[0].Tag).Result;
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
            DialogResult respuestaDialogo = MessageBox.Show("¿Desea restaurar la contraseña del administrador seleccionado?", "Restaurar contraseña", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuestaDialogo == DialogResult.Yes)
            {
                Usuario usuario = buscarObjeto((int)lstAdministradores.SelectedItems[0].Tag).Result;
                usuario.password = null;
                actualizarObjeto(usuario);
            }
        }

        private void cmsAdministradores_Opening(object sender, CancelEventArgs e)
        {
            this.verAdministradorToolStripMenuItem.Enabled = false;
            this.borrarAdministradorToolStripMenuItem.Enabled = false;
            this.restaurarContraseñaToolStripMenuItem.Enabled = false;
            if (lstAdministradores.SelectedItems.Count == 1)
            {
                this.verAdministradorToolStripMenuItem.Enabled = true;
                this.borrarAdministradorToolStripMenuItem.Enabled = true;
                this.restaurarContraseñaToolStripMenuItem.Enabled = true;

            }
        }
    }
}
