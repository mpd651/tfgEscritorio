using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfgEscritorio.modelo
{
    public class ActualizacionPedido
    {
        public int id { get; set; }

        public Pedido pedido { get; set; }

        public Usuario usuario { get; set; }

        public System.DateTime fecha { get; set; }

        public string motivo { get; set; }

    }
}
