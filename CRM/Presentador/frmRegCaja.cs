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

        private void frmRegCaja_Load(object sender, EventArgs e)
        {
            nDevoluciones transa = new nDevoluciones();
            cbEstado.DataSource = transa.getEstado();
            cbEstado.ValueMember = "idestado";
            cbEstado.DisplayMember = "estado";

            cbTransaccion.DataSource = transa.transacciones();
            cbTransaccion.ValueMember = "idtransaccion";
            cbTransaccion.DisplayMember = "docref";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            nDevoluciones insert = new nDevoluciones();
            bool result = insert.insertTransaccion(cbEstado.SelectedValue.ToString(), cbTransaccion.SelectedValue.ToString());

            if (result != false)
            {
                MessageBox.Show("Insercion Exitosa", "Caja", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                MessageBox.Show("Fallo Insercion", "Caja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            nDevoluciones editCaja = new nDevoluciones();
            bool result = editCaja.updateTrx(txtCaja.Text, cbEstado.SelectedValue.ToString());


            if (result != false)
            {
                MessageBox.Show("Update Exitosa", "Caja", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Fallo Update", "Caja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
