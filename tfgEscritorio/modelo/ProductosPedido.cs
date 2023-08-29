using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfgEscritorio.modelo
{
    public class ProductosPedido
    {
        public int productoPedidoid { get; set; }

        public Producto producto { get; set; }

        public Pedido pedido { get; set; }

        public int cantidad { get; set; }

        public System.DateTime hora { get; set; }
    }
}
