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

        public string tipodocumento { get; set; }

        public int idcliente { get; set; }

        public int idmoneda { get; set; }

        public int producto { get; set; }

        public int idvendedor { get; set; }

        public int idfactura { get; set; }
        public int idestado { get; set; }
        
    }
}
