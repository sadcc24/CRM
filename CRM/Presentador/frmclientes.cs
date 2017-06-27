using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Datos;
using Negocio;


namespace Presentador
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            eCClientes datoscliente = new eCClientes();
            datoscliente.nombre = txtnombre.Text;
            datoscliente.apellido = txtapellido.Text;
            datoscliente.telefono = Convert.ToInt32(txttelefono.Text);
            datoscliente.nit = Convert.ToInt32(txtnit.Text);
            datoscliente.direccion = txtdireccion.Text;
            datoscliente.email = txtemail.Text;

            datoscliente.saldo = Convert.ToInt32(txtsaldo.Text);
            datoscliente.subtotal = Convert.ToInt32(txtsubtotal.Text);





            nCClientes clientes = new nCClientes();

            bool result = clientes.insertClientes(datoscliente);

            if (result != false)
            {
                MessageBox.Show("Registro Insertado", "Insercion cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fallo Registro Insertado", "Fallo Insercion cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }
    }
}
