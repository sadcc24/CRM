using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eDevoluciones
    {
        public DateTime fechaDevolucion { get; set; }

        public string motivodev { get; set; }

        public int tipodev { get; set; }

        public int empresa { get; set; }

        public int sede { get; set; }

        public int proveedor { get; set; }

        public int producto { get; set; }

        public int factura { get; set; }
        
    }
}
