using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eInsertDevolucion
    {
        public int iddevolucion { get; set; }
        public int idbodega { get; set; }
        public int idproducto { get; set; }
        public string impuesto { get; set; }

        public string preciounitario { get; set; }
        public int cantidad { get; set; }

        public string comision { get; set; }
    }
}
