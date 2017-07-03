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
    public partial class frmRegCaja : Form
    {
        public frmRegCaja()
        {
            InitializeComponent();
        }

        private void txttipodevolucion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCancelacionCXC cancelacion = new frmCancelacionCXC();
            cancelacion.MdiParent = this.ParentForm;
            cancelacion.Show();
            this.Hide();
        }
    }
}
