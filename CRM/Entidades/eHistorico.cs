using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eHistorico
    {
        public int cuentacxc { get; set; }
        public int cliente { get; set; }

        public DateTime fecha { get; set; }

        public string cantidadpagada { get; set; }

        public string saldo { get; set; }
    }
}
