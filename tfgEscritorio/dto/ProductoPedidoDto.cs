using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tfgEscritorio.modelo;

namespace tfgEscritorio.dto
{
    internal class ProductoPedidoDto
    {
        public int productoPedidoid { get; set; }

        public string productoNombre { get; set; }

        public float productoPrecio { get; set; }

        public int cantidad { get; set; }

        public string hora { get; set; }
    }
}
