//autor: Melvin alejandro Batz Farfan
// carne: 0901-12-1049
//fecha 09-07-2017
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
    public partial class frmConceptos : Form
    {
        public frmConceptos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmConceptos_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtcuotas.Enabled = true;
            txtnombrecxc.Enabled = true;
            cmbMovimientos.Enabled = true;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcuotas.Text))
            {
                MessageBox.Show("Rellene los Datos Requeridos", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eCXC tipocxc = new eCXC();
                tipocxc.nombre = txtnombrecxc.Text;
                tipocxc.cuotaminima = txtcuotas.Text;
                tipocxc.cuotamaxima = cmbMovimientos.Text;

                tipocxc.estado = txtestado.Text;
                tipocxc.idtipopago = Convert.ToInt16(txttipopago.Text);



                nCXC tipodcxc = new nCXC();
                bool result1 = tipodcxc.inserttcxc(tipocxc);

                if (result1 != false)
                {
                    MessageBox.Show("Ingreso Exitoso", "Ingreso Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    nCXC allcxc = new nCXC();
                    frmPrincipalConceptosCxC frmcxc = new frmPrincipalConceptosCxC();
                    frmcxc.dgvconceptos.DataSource = allcxc.datatcxc();
                    txtcuotas.Clear();
                    txtnombrecxc.Clear();
                }
                else
                {
                    MessageBox.Show("Ingreso Fallido", "Ingreso Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            eCXC editconcxc = new eCXC();

            string idconcepto = txtidconcepto.Text;

            editconcxc.idtipopago = Convert.ToInt16(txttipopago.Text);
            editconcxc.idtipocxc = Convert.ToInt16(txtidconcepto.Text);
            editconcxc.nombre = txtnombrecxc.Text;
            editconcxc.cuotaminima = txtcuotas.Text;
            editconcxc.cuotamaxima = cmbMovimientos.SelectedText;

            editconcxc.estado = txtestado.Text;


            nCXC updateconceptos = new nCXC();
            bool result = updateconceptos.updateconcepto(editconcxc, idconcepto);

            if (result != false)
            {
                MessageBox.Show("Actualizacion Exitosa", "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nCXC allconceptos = new nCXC();
                frmPrincipalConceptosCxC conceptos = new frmPrincipalConceptosCxC();
                conceptos.dgvconceptos.DataSource = allconceptos.datatcxc();

                txtcuotas.Clear();
                txtidconcepto.Clear();
                txtidconcepto.Clear();
                cmbMovimientos.Refresh();
                txtnombrecxc.Clear();
            }
            else
            {
                MessageBox.Show("Actualizacion Fallida", "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void btnEliminar_Click(object sender, EventArgs e)
        {
            eCXC editconcxc = new eCXC();

            string idconcepto = txtidconcepto.Text;

            editconcxc.idtipocxc = Convert.ToInt16(txtidconcepto.Text);
            editconcxc.estado = txtestado.Text;


            nCXC delete = new nCXC();
            bool result = delete.deleteconcepto(editconcxc, idconcepto);

            if (result != false)
            {
                MessageBox.Show("Eliminacion Exitosa", "Eliminacion de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nCXC allconceptos = new nCXC();
                frmPrincipalConceptosCxC conceptos = new frmPrincipalConceptosCxC();
                conceptos.dgvconceptos.DataSource = allconceptos.datatcxc();

                txtnombrecxc.Clear();
                txtcuotas.Clear();
                txtidconcepto.Clear();
                txtidconcepto.Clear();
                cmbMovimientos.Refresh();
            }
            else
            {
                MessageBox.Show("Actualizacion Fallida", "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cmbMovimientos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


