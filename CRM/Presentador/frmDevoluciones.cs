using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Presentador
{
    public partial class frmDevoluciones : Form
    {
        public frmDevoluciones()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmDevRegistro devRegistro = new frmDevRegistro();
            devRegistro.Show();
        }

        private void frmDevoluciones_Load(object sender, EventArgs e)
        {
            ConnectionDBLocal cnn = new ConnectionDBLocal();
            dgvDevoluciones.DataSource = cnn.Select("SELECT * FROM VENDEDOR");
        }
    }
}
