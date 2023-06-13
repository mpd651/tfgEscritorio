using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfgEscritorio.modelo
{
    internal class Producto
    {
        int id { get; set; }

        string nombre { get; set; }

        float precio { get; set; }

        bool cocina { get; set; }

        Categoria categoria{get; set;}

        List<ProductosPedido> productosPedidos { get; set; }

    }
}
