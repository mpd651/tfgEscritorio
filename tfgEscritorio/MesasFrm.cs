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
    public partial class MesasFrm : Form
    {
        public MesasFrm()
        {
            InitializeComponent();
            RefrescarLista();
        }

        private async void RefrescarLista()
        {
            lstMesas.Items.Clear();
            string url = "http://localhost:8080/api/v1/mesa";

            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Mesa>(url, apiHelper.methodHttp.GET, null, true);


            if (oReply != null && oReply.StatusCode == "Accepted")
            {
                List<Mesa> mesas = (List<Mesa>)oReply.Data;

                foreach (Mesa mesa in mesas)
                {
                    ListViewItem fila = new ListViewItem(new string[] {Convert.ToString(mesa.numeroMesa)});
                    fila.Tag = mesa.id;
                    lstMesas.Items.Add(fila);
                }
            }
            else
            {

            }

        }

        private void nuevaMesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mesa mesa = new Mesa();
            MesaFrm propiedadesMesa = new MesaFrm(mesa);
            if (propiedadesMesa.ShowDialog() == DialogResult.OK)
            {
                crearObjeto(mesa);
            }
        }

        private async void crearObjeto(Mesa mesa)
        {
            string url = "http://localhost:8080/api/v1/mesa";

            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Mesa>(url, apiHelper.methodHttp.POST, mesa, false);

            RefrescarLista();
        }

        private void verMesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mesa mesa = buscarObjeto((int)lstMesas.SelectedItems[0].Tag).Result;

            MesaFrm propiedadesMesa = new MesaFrm(mesa);

            if (propiedadesMesa.ShowDialog() == DialogResult.OK)
            {
                actualizarObjeto(mesa);
            }
        }

        private async Task<Mesa> buscarObjeto(int id)
        {
            string url = "http://localhost:8080/api/v1/mesa/id?id=" + id;

            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Mesa>(url, apiHelper.methodHttp.GET, null, false).ConfigureAwait(false);

            return (Mesa)oReply.Data;
        }

        private async void actualizarObjeto(Mesa mesa)
        {
            string url = "http://localhost:8080/api/v1/mesa/modificar?id=" + mesa.id;
            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Mesa>(url, apiHelper.methodHttp.PUT, mesa, false);

            RefrescarLista();
        }

        private void borrarMesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuestaDialogo = MessageBox.Show("¿Desea eliminar la mesa seleccionada?", "Borrar mesa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuestaDialogo == DialogResult.Yes)
            {
                Mesa mesa = buscarObjeto((int)lstMesas.SelectedItems[0].Tag).Result;
                borrarObjeto(mesa);
            }
        }
        private async void borrarObjeto(Mesa mesa)
        {
            string url = "http://localhost:8080/api/v1/mesa/eliminar?id=" + mesa.id;
            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Mesa>(url, apiHelper.methodHttp.DELETE, mesa, false);

            RefrescarLista();
        }

        private void cmsMesas_Opening(object sender, CancelEventArgs e)
        {
            this.verMesaToolStripMenuItem.Enabled = false;
            this.borrarMesaToolStripMenuItem.Enabled = false;
            if (lstMesas.SelectedItems.Count == 1)
            {
                this.verMesaToolStripMenuItem.Enabled = true;
                this.borrarMesaToolStripMenuItem.Enabled = true;
            }
        }
    }
}
