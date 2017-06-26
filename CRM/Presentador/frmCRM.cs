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

        }

        private void campaniasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           
        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegCampania RegistoCampania = new frmRegCampania();
            RegistoCampania.MdiParent = this;
            RegistoCampania.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {


            frmtipocampania TipoCampania = new frmtipocampania();
            TipoCampania.MdiParent = this;
            TipoCampania.Show();
        }

        private void ingresoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmClientes IngresoClientes = new frmClientes();
            IngresoClientes.MdiParent = this;
            IngresoClientes.Show();
        }

        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatalogClientes CatalogoClientes = new frmCatalogClientes();
            CatalogoClientes.MdiParent = this;
            CatalogoClientes.Show();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCliente ConsultaClientes = new frmConsultaCliente();
            ConsultaClientes.MdiParent = this;
            ConsultaClientes.Show();
        }

        private void frmCRM_Load(object sender, EventArgs e)
        {

        }

        private void cuentasPorCobrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPrincipalConceptosCxC cuentascxc = new frmPrincipalConceptosCxC();
            cuentascxc.MdiParent = this;
            cuentascxc.Show();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaVendedores consultavendedor = new frmConsultaVendedores();
            consultavendedor.MdiParent = this;
            consultavendedor.Show();
        }

        private void tiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmIngresotipocampania Tipocamapnia = new frmIngresotipocampania();
            Tipocamapnia.MdiParent = this;
            Tipocamapnia.Show();
        }
    }
}
