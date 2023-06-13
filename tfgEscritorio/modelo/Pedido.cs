using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfgEscritorio.modelo
{
    internal class Pedido
    {
        int id { get; set; }

        Mesa mesa { get; set; }

        List<ActualizacionPedido> actualizaciones { get; set; }

        List<ProductosPedido> productosPedidos { get; set; }

        float importe { get; set; }

        System.DateTime fechaApertura { get; set; }

        System.DateTime fechaCierre { get; set; }

        bool pagado { get; set; }

        bool anulado { get; set; }

        string formaPago { get; set; }

        bool asignadoCamarero { get; set; }

    }
}
