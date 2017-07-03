using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class eMovimientoDev
    {
        public int idbodega { get; set; }
        public int idmovimiento { get; set; }

        public int idproducto { get; set; }

        public int cantidad { get; set; }

        public string costo { get; set; }

        public string precio { get; set; }
    }
}
