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
    public partial class frmPrincipalConceptosCxC : Form
    {
        public frmPrincipalConceptosCxC()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmConceptos conceptos = new frmConceptos();
            conceptos.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            nCXC conceptos = new nCXC();
            dgvconceptos.DataSource = conceptos.datatcxc();
        }

        private void frmPrincipalConceptosCxC_Load(object sender, EventArgs e)
        {
            nCXC conceptos = new nCXC();
            dgvconceptos.DataSource = conceptos.datatcxc();
        }

        private void dgvconceptos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvconceptos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmConceptos conceptos = new frmConceptos();

            string id = this.dgvconceptos.CurrentRow.Cells[0].Value.ToString();
            conceptos.txtidconcepto.Text = id;

            string nombre = this.dgvconceptos.CurrentRow.Cells[1].Value.ToString();
            conceptos.txtnombrecxc.Text = nombre;

            //string cuotamaxima = this.dgvconceptos.CurrentRow.Cells[2].Value.ToString();
            //conceptos.txtmaxima.Text = cuotamaxima;

            string cuotaminima = this.dgvconceptos.CurrentRow.Cells[3].Value.ToString();
            conceptos.txtcuotas.Text = cuotaminima;

            string pago = this.dgvconceptos.CurrentRow.Cells[4].Value.ToString();
            //conceptos.txtcompra.Text = pago;



            conceptos.MdiParent = this.ParentForm;
            conceptos.Show();

            //conceptos.txtcompra.Enabled = true;
            conceptos.txtcuotas.Enabled = true;
            //conceptos.txtmaxima.Enabled = true;
            conceptos.txtcuotas.Enabled = true;
            conceptos.btnBuscar.Enabled = false;
            conceptos.txtnombrecxc.Enabled = true;


        }
    }
}
