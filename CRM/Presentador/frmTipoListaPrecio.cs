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
    public partial class frmTipoListaPrecio : Form
    {
        public frmTipoListaPrecio()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmTipoListaPrecioReg TPreg = new frmTipoListaPrecioReg();
            TPreg.MdiParent = this.ParentForm;
            TPreg.Show();
        }

        private void frmTipoListaPrecio_Load(object sender, EventArgs e)
        {
            nTipoLista allTipoLista = new nTipoLista();
            dgvTipoListaPrecios.DataSource = allTipoLista.getAllTipoLista();

        }

        

        private void dgvTipoListaPrecios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmTipoListaPrecioReg frmTLPR = new frmTipoListaPrecioReg();
            string id = this.dgvTipoListaPrecios.CurrentRow.Cells[0].Value.ToString();
            frmTLPR.txtID.Text = id;
            string tipoLista = this.dgvTipoListaPrecios.CurrentRow.Cells[1].Value.ToString();
            frmTLPR.txtTipoLista.Text = tipoLista;



            frmTLPR.txtID.Enabled = true;
            frmTLPR.txtTipoLista.Enabled = true;

            frmTLPR.MdiParent = this.ParentForm;
            frmTLPR.Show();
        }
    }
}
