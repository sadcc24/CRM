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
using Negocio;

namespace Presentador
{
    public partial class frmFacturas : Form
    {
        public frmFacturas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmFacturaRegistro facRegistro = new frmFacturaRegistro();
            facRegistro.MdiParent = this.ParentForm;
            facRegistro.Show();
        }

        private void dgvFacturas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmFacturaRegistro facRegistro = new frmFacturaRegistro();
            string idFact = this.dgvFacturas.CurrentRow.Cells[0].Value.ToString();
            facRegistro.tbIdFac.Text = idFact;

            string TipoDocumento = this.dgvFacturas.CurrentRow.Cells[10].Value.ToString();
            facRegistro.tbTipoDocumento.Text = TipoDocumento;

            string Fecha = this.dgvFacturas.CurrentRow.Cells[8].Value.ToString();
            facRegistro.tbFecha.Text = Fecha;

            string Total = this.dgvFacturas.CurrentRow.Cells[7].Value.ToString();
            facRegistro.tbTotal.Text = Total;



            //string idProducto = this.dgvListaPrecios.CurrentRow.Cells[4].Value.ToString();
            //reglistaPrecios.txtProducto.Text = idProducto;

            facRegistro.MdiParent = this.ParentForm;
            facRegistro.Show();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            nFactura allFac = new nFactura();
            dgvFacturas.DataSource = allFac.getAllFactura();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            nFactura allFac = new nFactura();
            dgvFacturas.DataSource = allFac.getAllFactura();
        }
    }
}
