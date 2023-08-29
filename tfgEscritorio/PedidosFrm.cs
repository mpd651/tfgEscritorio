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

namespace tfgEscritorio
{
    public partial class PedidosFrm : Form
    {
        public PedidosFrm()
        {
            InitializeComponent();
            RefrescarLista();
        }

        private async void RefrescarLista()
        {
            lstPedidos.Items.Clear();

            string url = "http://localhost:8080/api/v1/pedido";

            Reply oReply = new Reply();

            oReply = await Consumer.Execute<PedidoDto>(url, apiHelper.methodHttp.GET, null, true);


            if (oReply != null && oReply.StatusCode == "Accepted")
            {
                List<PedidoDto> pedidos = (List<PedidoDto>)oReply.Data;

                foreach (PedidoDto pedido in pedidos)
                {
                    ListViewItem fila = new ListViewItem(new string[] {Convert.ToString(pedido.mesa.numeroMesa), Convert.ToString(pedido.importe), Convert.ToString(pedido.fechaApertura), Convert.ToString(pedido.fechaCierre), Convert.ToString(pedido.pagado)});
                    fila.Tag = pedido.id;
                    lstPedidos.Items.Add(fila);
                }
            }
            else
            {

            }

        }


        private void verPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PedidoDto dto = buscarObjeto((int)lstPedidos.SelectedItems[0].Tag).Result;
            Pedido pedido = new Pedido();
            pedido.id = dto.id;
            pedido.mesa = dto.mesa;
            pedido.importe = dto.importe;
            pedido.fechaApertura = dto.fechaApertura;
            pedido.fechaCierre = dto.fechaCierre;
            pedido.pagado = dto.pagado;
            pedido.anulado= dto.anulado;
            pedido.asignadoCamarero = dto.asignadoCamarero;

            PedidoFrm propiedadesPedido = new PedidoFrm(pedido);
            propiedadesPedido.Show();

        }

        private async Task<PedidoDto> buscarObjeto(int id)
        {
            string url = "http://localhost:8080/api/v1/pedido/id?id=" + id;

            Reply oReply = new Reply();

            oReply = await Consumer.Execute<PedidoDto>(url, apiHelper.methodHttp.GET, null, false).ConfigureAwait(false);

            return (PedidoDto)oReply.Data;
        }

        private async Task<Usuario> buscarUsuario(string username)
        {
            string url = "http://localhost:8080/api/v1/usuario/username?username=" + username;

            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Usuario>(url, apiHelper.methodHttp.GET, null, false).ConfigureAwait(false);

            return (Usuario)oReply.Data;
        }


        private void borrarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuestaDialogo = MessageBox.Show("¿Desea eliminar el pedido seleccionado?", "Borrar pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuestaDialogo == DialogResult.Yes)
            {
                PedidoDto pedido = buscarObjeto((int)lstPedidos.SelectedItems[0].Tag).Result;
                Usuario usuario = buscarUsuario(Consumer.username).Result;
                borrarObjeto(pedido.id, usuario);
            }
        }

        private async void borrarObjeto(long pedidoId, Usuario usuario)
        {
            string url = "http://localhost:8080/api/v1/pedido/anularPedido/usuarioId/pedidoId?usuarioId="+usuario.id+"&pedidoId=" + pedidoId;
            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Pedido>(url, apiHelper.methodHttp.PUT, null, false);

            RefrescarLista();
        }

        private void cmsPedidos_Opening(object sender, CancelEventArgs e)
        {
            this.verPedidoToolStripMenuItem.Enabled = false;
            this.borrarPedidoToolStripMenuItem.Enabled = false;
            if (lstPedidos.SelectedItems.Count == 1)
            {
                this.verPedidoToolStripMenuItem.Enabled = true;
                this.borrarPedidoToolStripMenuItem.Enabled = true;
            }
        }
    }
}
