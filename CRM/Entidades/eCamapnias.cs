using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eCamapnias
    {

        public int TipoCampania { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public DateTime fechainicial { get; set; }
        public DateTime fechafinal { get; set; }


        public int Empresa { get; set; }
        

    }
}
