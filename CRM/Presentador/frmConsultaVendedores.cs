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
    public partial class frmConsultaVendedores : Form
    {
        public frmConsultaVendedores()
        {
            InitializeComponent();
        }

        private void grdCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmvendoresc vendedores = new frmvendoresc();
            vendedores.Show();
        }
    }
}
