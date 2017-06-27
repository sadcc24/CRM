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
    public partial class frmCatalogClientes : Form
    {
        public frmCatalogClientes()
        {
            InitializeComponent();
        }

        private void frmCatalogClientes_Load(object sender, EventArgs e)
        {
            nCClientes clientes = new nCClientes();
            dgvclientes.DataSource = clientes.getAllClientes();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmClientes ClRegistro = new frmClientes();
            ClRegistro.MdiParent = this.ParentForm;
            ClRegistro.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
