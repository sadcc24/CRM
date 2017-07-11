using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eDevHistorico
    {
        public int idcuentaporcobrar { get; set; }
        public int idcliente { get; set; }
        public int idtipocxc { get; set; }
        public string fechapago { get; set; }
        public string  cantidadpagada { get; set; }
        public string saldorestante { get; set; }
    }
}
