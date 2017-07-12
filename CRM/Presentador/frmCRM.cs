
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Presentador
{
    public partial class frmCRM : Form

    {
        public string user { get; set; }
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
            //frmClientes IngresoClientes = new frmClientes();
            //IngresoClientes.MdiParent = this;
            //IngresoClientes.Show();
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
            this.BackgroundImage = global::Presentador.Properties.Resources.LogoCRM3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            toolStripStatusLabel3.Text = "Usuario: " + user;
            toolStripStatusLabel4.Text = DateTime.Now.ToString();
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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresotipocampania Tipocamapnia = new frmIngresotipocampania();
            Tipocamapnia.MdiParent = this;
            Tipocamapnia.Show();
        }

        private void tipoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTipoListaPrecio TipoListaPrecio = new frmTipoListaPrecio();
            TipoListaPrecio.MdiParent = this;
            TipoListaPrecio.Show();
        }

        private void modulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cajaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaja caja = new frmCaja();
            caja.MdiParent = this;
            caja.Show();
        }

        private void cancelacionCuentaACobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCancelacionCXC cancel = new frmCancelacionCXC();
            cancel.MdiParent = this;
            cancel.Show();
        }

        private void registroUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisterUser cancel = new frmRegisterUser();
            cancel.MdiParent = this;
            cancel.Show();
        }
    }
}

