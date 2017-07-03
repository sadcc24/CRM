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
    public partial class frmListaPreciosReg : Form
    {
        public frmListaPreciosReg()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            txtDescripcion.Enabled = true;
            txtPrecio.Enabled = true;
            cbEmpresa.Enabled = true;
            cbEstado.Enabled = true;
            cbProducto.Enabled = true;
            cbTipoLista.Enabled = true;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            eListaPrecio datoslistaPrecio = new eListaPrecio();
            datoslistaPrecio.idtipolista = Convert.ToInt16(cbTipoLista.SelectedValue);
            datoslistaPrecio.producto = Convert.ToInt16(cbProducto.SelectedValue);
            datoslistaPrecio.descripcion = txtDescripcion.Text;
            datoslistaPrecio.precio = txtPrecio.Text;
            datoslistaPrecio.estado = Convert.ToInt16(cbEstado.SelectedValue);
            datoslistaPrecio.empresa = Convert.ToInt16(cbEmpresa.SelectedValue);

            MessageBox.Show(cbTipoLista.SelectedValue + " " + cbProducto.SelectedValue + " " + cbEstado.SelectedValue + " " + cbEmpresa.SelectedValue + " " + txtDescripcion.Text + " " + txtPrecio.Text, "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            nListaPrecio listapre = new nListaPrecio();
            bool result = listapre.insertLisaPrecio(datoslistaPrecio);

            if (result != false)
            {
                MessageBox.Show("Registro Insertado", "Insercion Lista Precio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fallo Registro Insertado", "Fallo Insercion Vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

      
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            txtDescripcion.Clear();
            txtPrecio.Clear();
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            eListaPrecio editarListaPrecio = new eListaPrecio();
            string idLP = txtIdListaPrecio.Text;
            editarListaPrecio.idtipolista = Convert.ToInt16(cbTipoLista.SelectedValue);
            editarListaPrecio.producto = Convert.ToInt16(cbProducto.SelectedValue);
            editarListaPrecio.descripcion = txtDescripcion.Text;
            editarListaPrecio.precio = txtPrecio.Text;
            editarListaPrecio.estado = Convert.ToInt16(cbEstado.SelectedValue);
            editarListaPrecio.empresa = Convert.ToInt16(cbEmpresa.SelectedValue);
            
            nListaPrecio updatedLP = new nListaPrecio();
            bool result = updatedLP.updateListaPrecio(editarListaPrecio, idLP);

            if (result != false)
            {
                MessageBox.Show("Actualizacion Exitosa", "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nListaPrecio allLP = new nListaPrecio();
                frmListaPrecios frmLP = new frmListaPrecios();
                frmLP.dgvListaPrecios.DataSource = allLP.getAllListaPrecio();              

                txtDescripcion.Clear();
                txtPrecio.Clear();
                //txtProducto.Clear();
                //txtIdTipoLista.Clear();
            }
            else
            {
                MessageBox.Show("Actualizacion Fallida", "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            nListaPrecio deleteLp = new nListaPrecio();
            bool result = deleteLp.deleteListaPrecio(txtIdListaPrecio.Text);

            if (result != false)
            {
                MessageBox.Show("Registro Eliminado", "Eliminacion Lista Precio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdListaPrecio.Clear();
                //txtIdTipoLista.Clear();
                txtDescripcion.Clear();
                txtPrecio.Clear();
                //txtProducto.Clear();
            }
            else
            {
                MessageBox.Show("Fallo Eliminacion Reigstro", "Fallo Eliminacion Lista Precio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

      

        private void frmListaPreciosReg_Load(object sender, EventArgs e)
        {
            nListaPrecio getlistaPrecio = new nListaPrecio();
            DataTable filter = new DataTable();

            

            filter = getlistaPrecio.getFilterProducto();
            
            cbProducto.DataSource = filter;
            cbProducto.ValueMember = "idproducto";
            cbProducto.DisplayMember = "descripcion";
            

            

            DataTable filter1 = new DataTable();


            filter1 = getlistaPrecio.getFilterTipoLista();

            
            cbTipoLista.DataSource = filter1;
            cbTipoLista.ValueMember = "idtipolistaprecio";
            cbTipoLista.DisplayMember = "nombre";
            
            

            DataTable filter2 = new DataTable();

            filter2 = getlistaPrecio.getFilterEstado();

           
            cbEstado.DataSource = filter2;
            cbEstado.ValueMember = "idestado";
            cbEstado.DisplayMember = "estado";
            
            

            DataTable filter3 = new DataTable();

            filter3 = getlistaPrecio.getFilterEmpresa();

            
            cbEmpresa.DataSource = filter3;
            cbEmpresa.ValueMember = "idempresa";
            cbEmpresa.DisplayMember = "nombre_empresa";
            
            

        }
    }
}
