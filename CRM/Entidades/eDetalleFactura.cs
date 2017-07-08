using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eDetalleFactura
    {
        public int iddetallefactura { get; set; }

        public int idfactura { get; set; }

        public string cantidad { get; set; }

        public int idbodega { get; set; }

        public int idproducto { get; set; }

        public string preciounitario { get; set; }

        public double comision { get; set; }

        public double impuesto { get; set; }
    }
}
