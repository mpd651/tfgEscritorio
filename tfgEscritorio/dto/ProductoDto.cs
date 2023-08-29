using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tfgEscritorio.modelo;

namespace tfgEscritorio.dto
{
    internal class ProductoDto
    {
        public int id { get; set; }

        public string nombre { get; set; }

        public float precio { get; set; }

        public Categoria categoria { get; set; }

        public bool borrado { get; set; }
    }
}
