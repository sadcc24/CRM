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
    public partial class frmCotizacion : Form
    {
        public frmCotizacion()
        {
            InitializeComponent();
        }

        private void frmCotizacion_Load(object sender, EventArgs e)
        {
            nFactura allFac = new nFactura();
            dgvCotizaciones.DataSource = allFac.getAllCotizacion();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmFacturaRegistro facRegistro = new frmFacturaRegistro();
            facRegistro.MdiParent = this.ParentForm;
            facRegistro.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            nFactura allFac = new nFactura();
            dgvCotizaciones.DataSource = allFac.getAllCotizacion();
        }
    }
}
