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
using Entidades;
using Negocio;




namespace Presentador
{
    public partial class frmRegCampania : Form
    {
        public frmRegCampania()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           // frmtipocampania regcam = new frmtipocampania();



            // VALIDAR SI EL CAMPO SE ENCUENTRA VACIO
            //    {
            //     if (String.IsNullOrEmpty(txttelefono.Text))
            //  {
            //    MessageBox.Show("Rellene los Datos Requeridos: Telefono", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //  }
            // else
            //{

            eCamapnias datoscampanias = new eCamapnias();
                    datoscampanias.TipoCampania = Convert.ToInt16(cbtipocampania.SelectedValue);
                    datoscampanias.nombre = txtnombre.Text;
                    datoscampanias.descripcion = txtdescripcion.Text;
            datoscampanias.fechainicial = dtpfechainicial.Value;
            datoscampanias.fechafinal = dtpfechafinal.Value;
            datoscampanias.Empresa = Convert.ToInt16(cbempresa.SelectedValue);
                     





            //   MessageBox.Show(cbestado.SelectedValue + " " + txtnombre.Text + " " + txtapellido.Text + " " + txttelefono.Text + " " + txtdireccion.Text + " " + txtemail.Text + " " + txtsaldo.Text + " " + cbempresa.SelectedValue, "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);






            nCampanias inscampania = new nCampanias();

                   bool result = inscampania.insertCampa(datoscampanias);

                   if (result != false)
                    {
                        MessageBox.Show("Registro Insertado", "Insercion cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        nCClientes ccclientes = new nCClientes();
                        frmCatalogClientes frmCli = new frmCatalogClientes();
                nCampanias rcampa = new nCampanias();
                frmtipocampania regcam = new frmtipocampania();


           //     regcam.dgvcampanias.DataSource = rcampa.getAllCampanias();
                txtnombre.Clear();
                        txtdescripcion.Clear();

                

            }
                    else
                    {
                        MessageBox.Show("Fallo Registro Insertado", "Fallo Insercion cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


              //  }






            }

        private void Empresa_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmRepCampaniasCliente RCcliente = new frmRepCampaniasCliente();
            RCcliente.MdiParent = this.ParentForm;
            RCcliente.Show();

        }

        private void frmRegCampania_Load(object sender, EventArgs e)
        {
            
            nCClientes getemp = new nCClientes();
            nCampanias getcamp = new nCampanias();

            cbempresa.DataSource = getemp.getAllCompanies();
            cbempresa.ValueMember = "idempresa";
            cbempresa.DisplayMember = "nombre_empresa";


            cbtipocampania.DataSource = getcamp.getAllTipoCampanias();
            cbtipocampania.ValueMember = "ID_Campanias";
            cbtipocampania.DisplayMember = "nombre";


        }

        private void cbtipocampania_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtidcampania_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string iddev = txtidcampania.Text;
            nCampanias updatedev = new nCampanias();
            bool result = updatedev.deletecampania(iddev);


            if (result != false)
            {
                MessageBox.Show("Eliminacion Exitosa", "Eliminacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //nCampanias allDev = new nCampanias();
                //frmDevoluciones frmdev = new frmDevoluciones();
                //frmdev.dgvDevoluciones.DataSource = allDev.getAllDev();

                //txtmotivodev.Clear();
            }
            else
            {
                MessageBox.Show("Eliminacion Fallida", "Eliminacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           dtpfechainicial.Enabled = false;
            dtpfechafinal.Enabled = false;
            txtidcampania.Enabled = false;
            txtnombre.Enabled = false;
            txtdescripcion.Enabled = false;
            cbempresa.Enabled = false;
            cbtipocampania.Enabled = false;
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            eCamapnias dev = new eCamapnias();

            string idcamp = txtidcampania.Text;
            dev.fechainicial = dtpfechainicial.Value;
            dev.fechafinal = dtpfechafinal.Value;
            dev.TipoCampania = Convert.ToInt16(cbtipocampania.SelectedValue);
            dev.nombre = txtnombre.Text;
            dev.descripcion = txtdescripcion.Text;
            dev.Empresa = Convert.ToInt16(cbempresa.SelectedValue);

            nCampanias updatedev = new nCampanias();
            bool result = updatedev.updateCampania(dev, idcamp);


            if (result != false)
            {
                MessageBox.Show("Actualizacion Exitosa", "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nCampanias allDev = new nCampanias();
                frmtipocampania frmdev = new frmtipocampania();
                frmdev.dgvcampanias.DataSource = allDev.getAllCampanias();

               // txtmotivodev.Clear();
            }
            else
            {
                MessageBox.Show("Actualizacion Fallida", "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
