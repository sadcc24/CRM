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
            txtIdTipoLista.Enabled = true;
            txtDescripcion.Enabled = true;
            txtPrecio.Enabled = true;
            txtProducto.Enabled = true;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            eListaPrecio datoslistaPrecio = new eListaPrecio();
            datoslistaPrecio.idtipolista = txtIdTipoLista.Text;
            datoslistaPrecio.idproducto = txtProducto.Text;
            datoslistaPrecio.descripcion = txtDescripcion.Text;
            datoslistaPrecio.precio = txtPrecio.Text;

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

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIdTipoLista.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtProducto.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            eListaPrecio editarListaPrecio = new eListaPrecio();
            //string idLP = txtIdListaPrecio.Text;
            editarListaPrecio.idproducto = txtProducto.Text;
            editarListaPrecio.idtipolista = txtIdTipoLista.Text;
            editarListaPrecio.descripcion = txtDescripcion.Text;
            editarListaPrecio.precio = txtPrecio.Text;

            nListaPrecio updatedLP = new nListaPrecio();
           // bool result = updatedLP.updateListaPrecio(editarListaPrecio, idLP);

        //    if (result != false)
            {
                MessageBox.Show("Actualizacion Exitosa", "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nListaPrecio allLP = new nListaPrecio();
                frmListaPrecios frmLP = new frmListaPrecios();
                frmLP.dgvListaPrecios.DataSource = allLP.getAllListaPrecio();              

                txtDescripcion.Clear();
                txtPrecio.Clear();
                txtProducto.Clear();
                txtIdTipoLista.Clear();
           // }
           // else
          //  {
                MessageBox.Show("Actualizacion Fallida", "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            nListaPrecio deleteLp = new nListaPrecio();
          //  bool result = deleteLp.deleteListaPrecio(txtIdListaPrecio.Text);

           // if (result != false)
            //{
                MessageBox.Show("Registro Eliminado", "Eliminacion Lista Precio", MessageBoxButtons.OK, MessageBoxIcon.Information);
             //   txtIdListaPrecio.Clear();
          //      txtIdTipoLista.Clear();
           //     txtDescripcion.Clear();
           //     txtPrecio.Clear();
             //   txtProducto.Clear();
         //   }
          //  else
          //  {
           //     MessageBox.Show("Fallo Eliminacion Reigstro", "Fallo Eliminacion Lista Precio", MessageBoxButtons.OK, MessageBoxIcon.Information);
          //  }
        }

        private void frmListaPreciosReg_Load(object sender, EventArgs e)
        {

        }
    }
}
