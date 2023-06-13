using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tfgEscritorio.modelo
{
    internal class Usuario
    {
        public int id { get; set; }

        public string nombre { get; set; }

        public string apellidos { get; set; }

        public string userName { get; set; }

        public string password { get; set; }

        public string rol { get; set; }

    }
}
