﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eHistorico
    {
        public int idcuentacxc { get; set; }
        public int idcliente { get; set; }

        public int idtipocxc { get; set; }

        public string Fecha { get; set; }

        public string cantidadPagada { get; set; }

        public double saldo { get; set; }
    }
}
