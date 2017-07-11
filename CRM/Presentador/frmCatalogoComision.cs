using Negocio;
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
    public partial class frmCatalogoComision : Form
    {
        public frmCatalogoComision()
        {
            InitializeComponent();
        }

        private void frmCatalogoComision_Load(object sender, EventArgs e)
        {
            nComision comision = new nComision();
            dgvcomision.DataSource = comision.getComision();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            frmComision comision = new frmComision();
            comision.MdiParent = this.ParentForm;
            comision.Show();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            nComision comision = new nComision();
            dgvcomision.DataSource = comision.getComision();
        }

        private void dgvcomision_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmComision comision = new frmComision();
            string idcomision = this.dgvcomision.CurrentRow.Cells[0].Value.ToString();
            comision.txtidcomision.Text = idcomision;
            string nombre = this.dgvcomision.CurrentRow.Cells[1].Value.ToString();
            comision.cbvendedor.Text = nombre;

            string porcentaje = this.dgvcomision.CurrentRow.Cells[3].Value.ToString();
            comision.txtcomision.Text = porcentaje;
            string empresa = this.dgvcomision.CurrentRow.Cells[4].Value.ToString();
            comision.cbEmpresa.Text = empresa;
            string producto = this.dgvcomision.CurrentRow.Cells[6].Value.ToString();
            comision.cbproducto.Text = producto;

            comision.MdiParent = this.ParentForm;
            comision.Show();

        }
    }
}
