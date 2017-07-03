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

        public int cantidad { get; set; }

        public int idbodega { get; set; }

        public int idproducto { get; set; }

        public int preciounitario { get; set; }

        public int comision { get; set; }

        public int impuesto { get; set; }
    }
}
