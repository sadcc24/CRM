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

namespace Presentador
{
    public partial class frmCaja : Form
    {
        public frmCaja()
        {
            InitializeComponent();
        }

        private void frmCaja_Load(object sender, EventArgs e)
        {
            nCaja caja = new nCaja();
            dgvCaja.DataSource = caja.Caja();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            frmRegCaja regCaja = new frmRegCaja();
            regCaja.MdiParent = this.ParentForm;
            regCaja.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            nCaja caja = new nCaja();
            dgvCaja.DataSource = caja.Caja();
        }

        private void dgvCaja_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmRegCaja rgcaja = new frmRegCaja();
            string idCaja = this.dgvCaja.CurrentRow.Cells[0].Value.ToString();
            rgcaja.txtCaja.Text = idCaja;
            string Estado = this.dgvCaja.CurrentRow.Cells[1].Value.ToString();
            rgcaja.cbEstado.Text = Estado;
            string Trx = this.dgvCaja.CurrentRow.Cells[3].Value.ToString();
            rgcaja.cbTransaccion.Text = Trx;


            rgcaja.MdiParent = this.ParentForm;
            rgcaja.Show();


        }
    }
}
