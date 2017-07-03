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

namespace Presentador
{
    public partial class SelectingClient : Form
    {
        public SelectingClient()
        {
            InitializeComponent();
        }

        private void SelectingClient_Load(object sender, EventArgs e)
        {
            dgvClientes.AllowUserToAddRows = false;
            dgvFacturas.AllowUserToAddRows = false;

            nDevoluciones dev = new nDevoluciones();
            dgvClientes.DataSource = dev.getClients();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idcliente = this.dgvClientes.CurrentRow.Cells[0].Value.ToString();
            txtidCliente.Text = idcliente;
        }

        private void txtidCliente_TextChanged(object sender, EventArgs e)
        {
            nDevoluciones devFacturas = new nDevoluciones();
            dgvFacturas.DataSource = devFacturas.getFacturas(txtidCliente.Text);
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idcliente = this.dgvClientes.CurrentRow.Cells[0].Value.ToString();
            txtidCliente.Text = idcliente;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();

            nDevoluciones dev = new nDevoluciones();
            string idFactura = this.dgvFacturas.CurrentRow.Cells[0].Value.ToString();
            data = dev.getDetailFacturas(idFactura);

            frmDevRegistro devregistro = new frmDevRegistro();
            string idcliente = data.Rows[0]["idcliente"].ToString();
            devregistro.txtCliente.Text = idcliente;
            devregistro.txtMoneda.Text = data.Rows[0]["idmoneda"].ToString();
            devregistro.txtVendedor.Text = data.Rows[0]["idvendedor"].ToString();
            devregistro.txtFactura.Text = data.Rows[0]["idfactura"].ToString();
            devregistro.txtTipoFactura.Text = data.Rows[0]["idtipopago"].ToString();
            devregistro.txttipodevolucion.Text = "Factura.";
            devregistro.txttipodevolucion.Enabled = false;
            devregistro.txtFactura.Visible = true;
            devregistro.txtFacturadev.Visible = false;
            devregistro.btnGuardar.Enabled = true;
            devregistro.btnEditar.Enabled = false;
            devregistro.btnEliminar.Enabled = false;
            devregistro.txtDescripcion.Enabled = true;
            devregistro.btnCancelar.Enabled = true;
            
            devregistro.MdiParent = this.ParentForm;
            devregistro.Show();
            this.Hide();

        }
    }
}
