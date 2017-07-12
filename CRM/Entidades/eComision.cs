using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eComision
    {
        public int vendedor { get; set; }
        public int estado { get; set; }

        public string comision { get; set; }
        public int empresa { get; set; }
        public string marca { get; set; }

        public string producto { get; set; }
    }
}
