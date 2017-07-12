using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eRegisterUser
    {
        public string user { get; set; }

        public string password { get; set; }

        public string rol { get; set; }

        public int status { get; set; }

        public string pregunta { get; set; }

        public string respuesta = "CRM";

    }
}
