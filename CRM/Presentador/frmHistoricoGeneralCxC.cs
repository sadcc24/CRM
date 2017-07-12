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
    public partial class frmHistoricoGeneralCxC : Form
    {
        public frmHistoricoGeneralCxC()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmHistoricoGeneralCxC_Load(object sender, EventArgs e)
        {
            double totaldebe = 0;
            double totalhaber = 0;
            double totalsaldos = 0;

            nCXC cxcclientes = new nCXC();
            dgvgendebe.DataSource = cxcclientes.clientecxcdebe();

            dgvgendebe.AllowUserToAddRows = false;

            for (int i = 0; i < dgvgendebe.RowCount; i++)
            {

                totaldebe = Convert.ToDouble(this.dgvgendebe.Rows[i].Cells[6].Value.ToString());

            }
            ldebe.Text = Convert.ToString(totaldebe);

            dgvgenhaber.AllowUserToAddRows = false;
            for (int o = 0; o < dgvgenhaber.RowCount; o++)
            {
                totalhaber = Convert.ToDouble(this.dgvgenhaber.Rows[o].Cells[6].Value.ToString());
            }
            lhaber.Text = Convert.ToString(totalhaber);

            totalsaldos = totaldebe - totalhaber;
            totsaldo.Text = totalsaldos.ToString();

            dgvgenhaber.DataSource = cxcclientes.clientecxcdebe();

        }
    }
}
