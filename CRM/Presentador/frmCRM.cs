﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentador
{
    public partial class frmCRM : Form
    {
        public frmCRM()
        {
            InitializeComponent();
        }

        private void facturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFacturas facturas = new frmFacturas();
            facturas.MdiParent = this;
            facturas.Show();
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDevoluciones devoluciones = new frmDevoluciones();
            devoluciones.MdiParent = this;
            devoluciones.Show();
        }

        private void listaDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaPrecios listaPrecios = new frmListaPrecios();
            listaPrecios.MdiParent = this;
            listaPrecios.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas();
            ventas.MdiParent = this;
            ventas.Show();
        }
    }
}
