using Negocio;
using System;
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
    public partial class frmClienteCXC : Form
    {
        public frmClienteCXC()
        {
            InitializeComponent();
        }

        private void frmClienteCXC_Load(object sender, EventArgs e)
        {
            nDevoluciones dev = new nDevoluciones();
            dgvClientes.DataSource = dev.getClients();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idcliente = this.dgvClientes.CurrentRow.Cells[0].Value.ToString();
            txtidCliente.Text = idcliente;
        }

        private void txtidCliente_TextChanged(object sender, EventArgs e)
        {
            nDevoluciones devFacturas = new nDevoluciones();
            dgvFacturas.DataSource = devFacturas.getCXC(txtidCliente.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmCancelacionCXC cancelacion = new frmCancelacionCXC();


            nDevoluciones dev = new nDevoluciones();
            string idcuenta = this.dgvFacturas.CurrentRow.Cells[0].Value.ToString();
            cancelacion.txtdocumento.Text = idcuenta;
            string idcliente = this.dgvFacturas.CurrentRow.Cells[1].Value.ToString();
            cancelacion.txtcliente.Text = idcliente;

            cancelacion.MdiParent = this.ParentForm;
            cancelacion.Show();
            this.Hide();

        }
    }
}
