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
    public partial class frmvendoresc : Form
    {
        public frmvendoresc()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            eVendedor datosVendedor = new eVendedor();
            datosVendedor.nombre = txtnombre.Text;
            datosVendedor.apellido = txtapellido.Text;
            datosVendedor.email = txtemail.Text;
            datosVendedor.telefono = Convert.ToInt32(txttelefono.Text);

            nVendedores vendedor = new nVendedores();
            bool result = vendedor.insertVendedores(datosVendedor);

            if(result != false)
            {
                MessageBox.Show("Registro Insertado", "Insercion Vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fallo Registro Insertado", "Fallo Insercion Vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            nVendedores delete = new nVendedores();
            bool result = delete.deleteVendedores(txtidvendedor.Text);

            if (result != false)
            {
                MessageBox.Show("Registro Eliminado", "Eliminacion Vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtidvendedor.Clear();
                txtnombre.Clear();
                txtapellido.Clear();
                txtemail.Clear();
                txttelefono.Clear();
            }
            else
            {
                MessageBox.Show("Fallo Eliminacion Reigstro", "Fallo Eliminacion Vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

        }
    }
}
