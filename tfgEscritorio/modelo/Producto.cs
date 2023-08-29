using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfgEscritorio.modelo
{
    public class Producto
    {
        public int id { get; set; }

        public string nombre { get; set; }

        public float precio { get; set; }

        public Categoria categoria{get; set;}

        public List<ProductosPedido> productosPedidos { get; set; }

    }
}
