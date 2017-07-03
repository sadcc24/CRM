using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Presentador
{
    public partial class frmCancelacionCXC : Form
    {
        public frmCancelacionCXC()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmClienteCXC clientecxc = new frmClienteCXC();
            clientecxc.MdiParent = this.ParentForm;
            clientecxc.Show();
            this.Hide();
        }

        private void txtdocumento_TextChanged(object sender, EventArgs e)
        {
            if(txtdocumento.Text !="")
            {
                nDevoluciones historico = new nDevoluciones();
                dgvHistorico.DataSource = historico.historicocxc(txtdocumento.Text);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            eHistorico historico = new eHistorico();
            historico.cliente = Convert.ToInt32(txtcliente.Text);
            historico.cuentacxc = Convert.ToInt32(txtdocumento.Text);
            historico.fecha = dtpfechadev.Value;
            historico.cantidadpagada = txtCantidad.Text;
            historico.saldo = txtSaldo.Text;

            nCaja caja = new nCaja();
            bool result = caja.insertHistorico(historico);

            if (result != false)
            {
                MessageBox.Show("Ingreso Exitoso", "Ingreso Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Ingreso Fallido", "Ingreso Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
