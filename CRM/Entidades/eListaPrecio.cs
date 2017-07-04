using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eListaPrecio
    {
        public int idlistaprecio { get; set; }

        public int idtipolista { get; set; }

        public string descripcion { get; set; }

        public string precio { get; set; }

        public int estado { get; set; }

        public int empresa { get; set; }

        public int producto { get; set; }

    }
}
