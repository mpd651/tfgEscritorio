using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfgEscritorio.modelo
{
    internal class ProductosPedido
    {
        int id { get; set; }

        Producto producto { get; set; }

        Pedido pedido { get; set; }

        bool servido { get; set; }

        int cantidad { get; set; }

        System.DateTime hora { get; set; }
    }
}
