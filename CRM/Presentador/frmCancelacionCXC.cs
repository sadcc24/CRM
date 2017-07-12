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
using Entidades;

namespace Presentador
{
    public partial class frmCancelacionCXC : Form
    {
        public frmCancelacionCXC()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmClienteCXC clientecxc = new frmClienteCXC();
            clientecxc.MdiParent = this.ParentForm;
            clientecxc.Show();
            this.Hide();
        }

        private void txtdocumento_TextChanged(object sender, EventArgs e)
        {
            if(txtdocumento.Text !="")
            {
                nDevoluciones historico = new nDevoluciones();
                dgvHistorico.DataSource = historico.historicocxc(txtdocumento.Text, txtcliente.Text);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            eHistorico historico = new eHistorico();
            historico.idcliente = Convert.ToInt32(txtcliente.Text);
            historico.idcuentacxc = Convert.ToInt32(txtdocumento.Text);
            historico.Fecha = dtpfechadev.Value.ToString();
            historico.idtipocxc = Convert.ToInt16(cbTipocxc.SelectedValue.ToString());
            historico.cantidadPagada = txtCantidad.Text;
           // historico.cantidadpagada = txtCantidad.Text;

            nDevoluciones dev = new nDevoluciones();
            DataTable saldo = new DataTable();
            saldo = dev.checkSaldo(txtcliente.Text);

            double saldoCliente = Convert.ToDouble(saldo.Rows[0]["saldorestante"].ToString());
            double Cantidad = Convert.ToDouble(txtCantidad.Text);

            double TotalSaldo = saldoCliente - Cantidad;

            if(TotalSaldo != 0.00)
            {
                historico.saldo = TotalSaldo;
                nCaja caja = new nCaja();
                bool result = caja.insertHistorico(historico);

                if (result != false)
                {
                    MessageBox.Show("Ingreso Exitoso", "Ingreso Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSaldo.ResetText();
                    txtidhistorico.ResetText();
                    txtdocumento.ResetText();
                    txtcliente.ResetText();
                    txtCantidad.ResetText();
                    dgvHistorico.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Ingreso Fallido", "Ingreso Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }else
            {
                MessageBox.Show("Ingreso Pago", "No hay saldo a Pagar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


          
        }

        private void frmCancelacionCXC_Load(object sender, EventArgs e)
        {
            nDevoluciones dev = new nDevoluciones();


            cbTipocxc.DataSource = dev.getTipocxc();
            cbTipocxc.ValueMember = "idtipocxc";
            cbTipocxc.DisplayMember = "nombre";
        }

        private void dgvHistorico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string idhistorico = this.dgvHistorico.CurrentRow.Cells[0].Value.ToString();
            txtidhistorico.Text = idhistorico;
            string cuentacxc  = this.dgvHistorico.CurrentRow.Cells[1].Value.ToString();
            txtdocumento.Text = cuentacxc;
            string idcliente = this.dgvHistorico.CurrentRow.Cells[3].Value.ToString();
            txtcliente.Text = idcliente;
            string idtipocxc = this.dgvHistorico.CurrentRow.Cells[4].Value.ToString();
            
            string fecha = this.dgvHistorico.CurrentRow.Cells[6].Value.ToString();
            dtpfechadev.Text = fecha;

            string pago = this.dgvHistorico.CurrentRow.Cells[7].Value.ToString();
            txtCantidad.Text = pago;

            string saldo = this.dgvHistorico.CurrentRow.Cells[8].Value.ToString();
            txtSaldo.Text = saldo;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            nDevoluciones delete = new nDevoluciones();
            bool result = delete.deleteHistorico(txtidhistorico.Text);

            if (result != false)
            {
                MessageBox.Show("Eliminacion Pago", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSaldo.ResetText();
                txtidhistorico.ResetText();
                txtdocumento.ResetText();
                txtcliente.ResetText();
                txtCantidad.ResetText();
                dgvHistorico.DataSource = null;
            }
            else
            {
                MessageBox.Show("Fallo Eliminacion Pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
