using Entidades;
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
    public partial class frmComision : Form
    {
        public frmComision()
        {
            InitializeComponent();
        }

        private void frmComision_Load(object sender, EventArgs e)
        {
            nComision comision = new nComision();
            cbEmpresa.DataSource = comision.empresa();
            cbEmpresa.ValueMember = "idempresa";
            cbEmpresa.DisplayMember = "nombre_empresa";

            cbmarca.DataSource = comision.marca();
            cbmarca.ValueMember = "idmarca";
            cbmarca.DisplayMember = "descripcion";

            cbproducto.DataSource = comision.producto();
            cbproducto.ValueMember = "idproducto";
            cbproducto.DisplayMember = "descripcion";

            cbvendedor.DataSource = comision.vendedores();
            cbvendedor.ValueMember = "idvendedor";
            cbvendedor.DisplayMember = "Nombre";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            eComision comision = new eComision();
            comision.estado = 1;
            comision.empresa = Convert.ToInt32(cbEmpresa.SelectedValue.ToString());
            comision.marca = Convert.ToInt32(cbmarca.SelectedValue.ToString());
            comision.producto = Convert.ToInt32(cbproducto.SelectedValue.ToString());
            comision.vendedor = Convert.ToInt32(cbvendedor.SelectedValue.ToString());
            comision.comision = txtcomision.Text;

            nComision insert = new nComision();
            bool result = insert.insertcomision(comision);

            if (result != false)
            {
                MessageBox.Show("Ingreso Exitoso", "Ingreso Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Ingreso Fallido", "Ingreso Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

    
       

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            eComision comision = new eComision();
            comision.comision = txtcomision.Text;
            comision.empresa = Convert.ToInt32(cbEmpresa.SelectedValue.ToString());
            comision.estado = 1;
            comision.marca = Convert.ToInt32(cbmarca.SelectedValue.ToString());
            comision.producto = Convert.ToInt32(cbproducto.SelectedValue.ToString());
            comision.vendedor = Convert.ToInt32(cbvendedor.SelectedValue.ToString());

            nComision c = new nComision();
            bool result = c.updatecom(comision, txtidcomision.Text);

            if (result != false)
            {
                MessageBox.Show("Update Exitoso", "Update Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Update Fallido", "Update Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultM = MessageBox.Show("Desea Eliminar la Devolucion?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultM != DialogResult.No)
            {


                nComision delete = new nComision();
                bool result = delete.deletecom(txtidcomision.Text);


                if (result != false)
                {
                    MessageBox.Show("Eliminacion Exitosa", "Eliminacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Eliminacion Fallida", "Eliminacion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

    }
}
