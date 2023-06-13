using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfgEscritorio.modelo
{
    internal class ActualizacionPedido
    {
        int id { get; set; }

        Pedido pedido { get; set; }

        Usuario usuario { get; set; }

        System.DateTime fecha { get; set; }

        string motivo { get; set; }

    }
}
