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
    }
}
