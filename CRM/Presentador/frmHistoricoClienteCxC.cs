//autor: Melvin alejandro Batz Farfan
// carne: 0901-12-1049
//fecha 09-07-2017
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
    public partial class frmHistoricoClienteCxC : Form
    {
        public frmHistoricoClienteCxC()
        {
            InitializeComponent();
        }

        private void frmHistoricoCxC_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            double totaldebe = 0;
            double totalhaber = 0;
            double totalsaldos = 0;
            

            eCXC clientesbq = new eCXC();
            clientesbq.idclientecxc = Convert.ToInt16(txtIdClientecxc.Text);
            clientesbq.nombreclientecxc = txtnombreclientecxc.Text;
        

            nCXC cxcclientes = new nCXC();
            dgvDebe.DataSource = cxcclientes.clientecxcdebe();

            dgvDebe.AllowUserToAddRows = false;

            for (int i = 0; i < dgvDebe.RowCount; i++)
            {

                totaldebe = Convert.ToDouble(this.dgvDebe.Rows[i].Cells[6].Value.ToString());
                
            }
            labeldebe.Text = Convert.ToString(totaldebe);

            dgvHaber.DataSource = cxcclientes.clientecxchaber();
            dgvHaber.AllowUserToAddRows = false;
            for (int o = 0; o < dgvHaber.RowCount; o++)
            {
                totalhaber = Convert.ToDouble(this.dgvHaber.Rows[o].Cells[6].Value.ToString());
                            }
            labelhaber.Text = Convert.ToString(totalhaber);

            totalsaldos = totaldebe - totalhaber;
            saldos.Text = totalsaldos.ToString();
                
        }

      

        private void dgvHaber_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            labeldebe.ResetText();
            labelhaber.ResetText();
            saldos.ResetText();

            txtIdClientecxc.Clear();
            txtnombreclientecxc.Clear();
            DataTable dt = (DataTable)dgvDebe.DataSource;
            dt.Clear();

            DataTable dt2 = (DataTable)dgvHaber.DataSource;
            dt2.Clear();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
