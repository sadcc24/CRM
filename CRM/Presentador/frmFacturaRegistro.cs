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
    public partial class frmFacturaRegistro : Form
    {
        public frmFacturaRegistro()
        {
            InitializeComponent();
        }

        private void frmFacturaRegistro_Load(object sender, EventArgs e)
        {
            nFactura getFac = new nFactura();

            dgvCliente.DataSource = getFac.getAllCliente();

            //cbCliente.DataSource = getFac.getAllCliente();
            //cbCliente.ValueMember = "idcliente";
            //cbCliente.DisplayMember = "nombre";

            


            cbVendedor.DataSource = getFac.getAllVendedor();
            cbVendedor.ValueMember = "idvendedor";
            cbVendedor.DisplayMember = "nombre";

            cbTipoPago.DataSource = getFac.getAllTipoPago();
            cbTipoPago.ValueMember = "idtipopago";
            cbTipoPago.DisplayMember = "nombre";


            cbEstado.DataSource = getFac.getAllEstado();
            cbEstado.ValueMember = "idestado";
            cbEstado.DisplayMember = "estado";

            cbMoneda.DataSource = getFac.getAllMoneda();
            cbMoneda.ValueMember = "idmoneda";
            cbMoneda.DisplayMember = "nombre_moneda";

            nDetalleFactura nDetlleFac = new nDetalleFactura();
            dgvDetalleFactura.DataSource = nDetlleFac.getAllDetalleFac(tbIdFac.Text);
            


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //cbCliente.Enabled = true;
            cbVendedor.Enabled = true;
            cbTipoPago.Enabled = true;
            cbEstado.Enabled = true;
            cbMoneda.Enabled = true;
            //tbTipoDocumento.Enabled = true;
            dtpFecha.Enabled = true;
            tbTotal.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            eFactura datosFac = new eFactura ();
            datosFac.idcliente = Convert.ToInt16(this.dgvCliente.CurrentRow.Cells[0].Value.ToString());
            datosFac.idvendedor = Convert.ToInt16(cbVendedor.SelectedValue);
            datosFac.idmoneda = Convert.ToInt16(cbMoneda.SelectedValue);
            datosFac.total = Convert.ToInt16(tbTotal.Text);
            datosFac.subtotal = Convert.ToInt16(tbTotal.Text);
            datosFac.impuesto = Convert.ToInt16(tbTotal.Text);
            datosFac.fecha = dtpFecha.Value;
            datosFac.tipodocumento = "DPI";
            datosFac.impuesto = Convert.ToInt16(tbTotal.Text);
            datosFac.idestado = Convert.ToInt16(cbEstado.SelectedValue);
            datosFac.idtipopago = Convert.ToInt16(cbTipoPago.SelectedValue);

            nFactura listaFac = new nFactura();
            bool result = listaFac.insertFactura(datosFac);
            

            if (result != false)
            {

                dgvFac.DataSource = listaFac.getLastIdFactura();
                string idfac = this.dgvFac.CurrentRow.Cells[0].Value.ToString();

                //DataTable id = new DataTable();                
                //id = getid.getFacturaid();
                //eDetalleFactura idet = new eDetalleFactura();
                //idet.idfactura = Convert.ToInt32(id.Rows[0].ToString());

                MessageBox.Show("Registro Insertado ", "Insercion Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fallo Registro Insertado", "Fallo Insercion Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //tbFecha.Clear();
            //tbTipoDocumento.Clear();
            tbTotal.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            nFactura deleteFac = new nFactura();
            bool result = deleteFac.deleteFactura(tbIdFac.Text);

            if (result != false)
            {
                MessageBox.Show("Registro Eliminado", "Eliminacion Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //tbFecha.Clear();
                //tbTipoDocumento.Clear();
                tbTotal.Clear();
            }
            else
            {
                MessageBox.Show("Fallo Eliminacion Reigstro", "Fallo Eliminacion Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            eFactura datosFac = new eFactura();
            string idfac = tbIdFac.Text;
            datosFac.idcliente = Convert.ToInt16(this.dgvCliente.CurrentRow.Cells[0].Value.ToString());
            datosFac.idvendedor = Convert.ToInt16(cbVendedor.SelectedValue);
            datosFac.idmoneda = Convert.ToInt16(cbMoneda.SelectedValue);
            datosFac.total = Convert.ToInt16(tbTotal.Text);
            datosFac.subtotal = Convert.ToInt16(tbTotal.Text);
            datosFac.impuesto = Convert.ToInt16(tbTotal.Text);
            datosFac.fecha = dtpFecha.Value;
            //datosFac.tipodocumento = tbTipoDocumento.Text;
            datosFac.impuesto = Convert.ToInt16(tbTotal.Text);
            datosFac.idestado = Convert.ToInt16(cbEstado.SelectedValue);
            datosFac.idtipopago = Convert.ToInt16(cbTipoPago.SelectedValue);

            nFactura listaFac = new nFactura();
            bool result = listaFac.updateFactura(datosFac, idfac);


            if (result != false)
            {
                MessageBox.Show("Actualizacion Exitosa", "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nDevoluciones allDev = new nDevoluciones();
                frmDevoluciones frmdev = new frmDevoluciones();
                frmdev.dgvDevoluciones.DataSource = allDev.getAllDev();

                
            }
            else
            {
                MessageBox.Show("Actualizacion Fallida", "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            frmDetalleFactura detalleFactura = new frmDetalleFactura();
            eDetalleFactura detFac = new eDetalleFactura();
            detalleFactura.MdiParent = this.ParentForm;

            detFac.idfactura = Convert.ToInt16(this.dgvFac.CurrentRow.Cells[0].Value.ToString());
            detalleFactura.idfactura = detFac.idfactura;
            detalleFactura.Show();
            
            
        }

        

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string saldo = this.dgvCliente.CurrentRow.Cells[4].Value.ToString();
            double saldototal = Convert.ToDouble(saldo);
            if (saldototal >= 1000)
            {
                MessageBox.Show("El cliente debe mas de 1000, no se le dara credito", "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGuardar.Enabled = false;
            }
            else
            {
                btnGuardar.Enabled = true;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            nDetalleFactura nDetlleFac = new nDetalleFactura();
            dgvDetalleFactura.DataSource = nDetlleFac.getAllDetalleFac(tbIdFac.Text);

            

         }
    }
}
