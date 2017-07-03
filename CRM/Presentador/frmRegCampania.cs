﻿using System;
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

                        //  frmCli.dgvclientes.DataSource = ccclientes.getAllClientes();
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
            cbtipocampania.ValueMember = "idtipocampania";
            cbtipocampania.DisplayMember = "nombre";


        }

        private void cbtipocampania_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
