using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eCuentaXCobrar
    {
        public int idcuentaxcobrar { get; set; }

        public int idtipocxc { get; set; }

        public int idvendedor { get; set; }

        public int idfactura { get; set; }

        public string fecha { get; set; }

        public int idmoneda { get; set; }

        public double total { get; set; }

        public double subtotal { get; set; }

        public int idcliente { get; set; }

        public int idestado { get; set; }

        public int iddetallepago { get; set; }

        public int iddevolucion { get; set; }
    }
}
