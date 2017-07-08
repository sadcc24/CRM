using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eFactura
    {
        public int idfactura { get; set; }

        public int idcliente { get; set; }

        public int idvendedor { get; set; }

        public int idmoneda { get; set; }

        public int total { get; set; }

        public int subtotal { get; set; }

        public int impuesto { get; set; }

        public DateTime fecha { get; set; }

        public string tipodocumento { get; set; }

        public int idestado { get; set; }

        public int idtipopago { get; set; }

        
    }
}
