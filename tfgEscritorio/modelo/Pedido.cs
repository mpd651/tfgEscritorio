using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfgEscritorio.modelo
{
    public class Pedido
    {
        public int id { get; set; }

        public Mesa mesa { get; set; }

        public List<ActualizacionPedido> actualizaciones { get; set; }

        public List<ProductosPedido> productosPedidos { get; set; }

        public float importe { get; set; }

        public string fechaApertura { get; set; }

        public string fechaCierre { get; set; }

        public bool pagado { get; set; }

        public bool anulado { get; set; }

        public bool asignadoCamarero { get; set; }

    }
}
