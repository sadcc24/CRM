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
    public partial class frmTipoListaPrecioReg : Form
    {
        public frmTipoListaPrecioReg()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtTipoLista.Text))
            {
                MessageBox.Show("Rellene los Datos Requeridos: Nombre de Tipo de lista", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eTipoLista eTipo = new eTipoLista();
                eTipo.idtipoListaPrecio = txtID.Text;
                eTipo.nombreTipoLista = txtTipoLista.Text;
                

                nTipoLista insertDev = new nTipoLista();
                bool result = insertDev.insertTipoLista(eTipo);

                if (result != false)
                {
                    MessageBox.Show("Ingreso Exitoso", "Ingreso Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Ingreso Fallido", "Ingreso Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Limpiar los textbox
            txtID.Clear();
            txtTipoLista.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            string idtipoLista = txtID.Text;
            nTipoLista updatedev = new nTipoLista();
            bool result = updatedev.deleteTipoLista(idtipoLista);

            if (result != false)
            {
                MessageBox.Show("Eliminacion Exitosa", "Eliminacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Eliminacion Fallida", "Eliminacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            txtTipoLista.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            eTipoLista Tipolista = new eTipoLista();
            string idTipoLista = txtID.Text;
            Tipolista.nombreTipoLista = txtTipoLista.Text; 

            nTipoLista updatetipoLista = new nTipoLista();
            bool result = updatetipoLista.updateTipoLista(Tipolista, idTipoLista);

            if (result != false)
            {
                MessageBox.Show("Actualizacion Exitosa", "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Actualizacion Fallida", "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmTipoListaPrecioReg_Load(object sender, EventArgs e)
        {

        }
    }
}
