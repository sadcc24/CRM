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
    public partial class frmListaPrecios : Form
    {
        public frmListaPrecios()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmListaPreciosReg PreciosReg = new frmListaPreciosReg();
            PreciosReg.MdiParent = this.ParentForm;
            PreciosReg.Show();
        }
    }
}
