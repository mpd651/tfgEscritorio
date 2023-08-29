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
    public partial class PedidoFrm : Form
    {

        private Pedido pedido;

        public PedidoFrm()
        {
            InitializeComponent();
            RefrescarLista();
        }

        public PedidoFrm(Pedido pedido)
        {
            InitializeComponent();
            this.pedido = pedido;
            RefrescarLista();

            this.DialogResult = DialogResult.Cancel;

            txtNumeroMesa.Text = Convert.ToString(pedido.mesa.numeroMesa);
            txtImporte.Text = Convert.ToString(pedido.importe);
            
            txtFechaApertura.Text = Convert.ToString(pedido.fechaApertura);
            txtFechaCierre.Text = Convert.ToString(pedido.fechaCierre);
            txtPagado.Text = Convert.ToString(pedido.pagado);

        }

        private async void RefrescarLista()
        {
            lstProductosPedido.Items.Clear();
            string url = "http://localhost:8080/api/v1/productosPedido?pedidoId="+pedido.id;

            Reply oReply = new Reply();

            oReply = await Consumer.Execute<ProductoPedidoDto>(url, apiHelper.methodHttp.GET, null, true);


            if (oReply != null && oReply.StatusCode == "Accepted")
            {
                List<ProductoPedidoDto> productosPedidos = (List<ProductoPedidoDto>)oReply.Data;

                foreach (ProductoPedidoDto productosPedido in productosPedidos)
                {
                    ListViewItem fila = new ListViewItem(new string[] { productosPedido.productoNombre, Convert.ToString(productosPedido.cantidad), Convert.ToString(productosPedido.hora)});
                    fila.Tag = productosPedido.productoPedidoid;
                    lstProductosPedido.Items.Add(fila);
                }
            }
            else
            {

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
