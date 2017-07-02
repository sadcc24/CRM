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
    public partial class frmtipocampania : Form
    {
        public frmtipocampania()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            frmRegCampania CRegistro = new frmRegCampania();
            CRegistro.MdiParent = this.ParentForm;
            CRegistro.Show();

        }

        private void frmtipocampania_Load(object sender, EventArgs e)
        {
            nCampanias campanias = new nCampanias();
            dgvcampanias.DataSource = campanias.getAllCampanias();
        }
    }
}
